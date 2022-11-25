using AdminPanel.DataAccessLayer.Abstract.Other.EntityFramework.Oracle;
using AdminPanel.EntityLayer.Abctract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base.Oracle
{
    public class EntityEfDalOracle<TEntity, TContext> : EntityEfDal<TEntity,TContext>,IEntityEfDalBaseOracle<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
   
    {
        //Override
        public async Task<bool> AddAsync(TEntity entity, DateTime? kayitZamani = null)
        {
            bool result = false;
            using (TContext context = new TContext())
            {

                if (entity.isNotNull())//entity.isNull() normalde ekleme nesnesinde Id olmaz lakin oracle için gerekli 
                {
                    
                    // son id yi alma start
                    int id = (context.Set<TEntity>().ToList().OrderByDescending(p => p.ID).FirstOrDefault()).ID;
                    id++;
                    entity.ID = id;
                    // son id yi alma end
                    context.Entry(entity).State = EntityState.Added;
                    int response = await context.SaveChangesAsync();

                    if (response > 0)
                        result = true;
                }
            }
            return result;
        }


        // Entity total count get
        public async Task<int> GetTotalCountAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            int response = 0;
            using (TContext context = new TContext())
            {
                response = filter == null ? await context.Set<TEntity>().CountAsync()
                    : await context.Set<TEntity>().Where(filter).CountAsync();
            }
                return response;
        }


        public async Task<List<TEntity>> GetPaginationOfFilter(Expression<Func<TEntity, bool>>? filter = null, int pageItemsCount, int pageIndex)
        {
            List<TEntity> response = null;

            int totalItems = await GetTotalCountAsync(filter);

            int mod = totalItems % pageItemsCount;
            int pageCount = mod == 0 ? totalItems / pageItemsCount:((totalItems-mod)/pageItemsCount)+1;

            int itemIndex = pageIndex != 0 ? pageCount * pageIndex-1:0;

            if (pageIndex > pageCount)
            {
                throw new Exception("Geçersiz parametre / istek");
            }

            using (TContext context = new TContext()) {
                response = filter == null ? await filtreYok() : await filtreVar();

                // local function
                async Task<List<TEntity>> filtreYok()
                {
                    return await context.Set<TEntity>().OrderBy(p=>p.ID).Skip(itemIndex).Take(pageItemsCount).ToListAsync();
                }

                async Task<List<TEntity>> filtreVar()
                {
                    return await context.Set<TEntity>().OrderBy(p => p.ID).Where(filter).Skip(itemIndex).Take(pageItemsCount).ToListAsync();
                }

            }
            return response;
        }

        
    }
}
