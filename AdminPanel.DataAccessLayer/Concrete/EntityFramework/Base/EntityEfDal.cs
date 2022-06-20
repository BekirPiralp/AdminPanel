using AdminPanel.DataAccessLayer.Abstract.Other.EntityFramework;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework;
using AdminPanel.EntityLayer.Abctract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base
{
    public class EntityEfDal<TEntity, TContext> : IEntityEfDalBase<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext,new()
    {

        public async Task<bool> AddAsync(TEntity entity,DateTime? kayitZamani = null)
        {
            bool result = false;
            using (TContext context = new TContext())
            {
                
                if (entity.isNotNull())
                {
                    entity.kayitZamani = kayitZamani != null ? (DateTime)kayitZamani : DateTime.Now;

                    context.Entry(entity).State = EntityState.Added;
                    int response = await context.SaveChangesAsync();

                    if (response > 0)
                        result = true;
                }
            }
            return result;
        }

        public async Task<bool> DeleteAsync(TEntity entity, DateTime? silmeZamani = null)
        {
            bool result = false;
            using (TContext context = new TContext())
            {
                if (entity.isIdNotEmpty() & !entity.silinmisMi())
                {
                    entity.silmeZamani = silmeZamani != null ? (DateTime)silmeZamani : DateTime.Now;

                    // silme işlemi sanal olacak on göre ayarlama yapılacak
                    //context.Entry(entity).State = EntityState.Deleted;
                    entity.sil = true;
                    context.Entry(entity).State = EntityState.Modified;
                    int response = await context.SaveChangesAsync();

                    if (response > 0)
                        result = true;
                }
            }
            return result;
        }

        public async Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            List<TEntity> result;
            using (TContext context = new TContext())
            {
                result = filter == null ? await context.Set<TEntity>().ToListAsync()
                    : await context.Set<TEntity>().Where(filter).ToListAsync();
            }
            return result;
        }

        //public async Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter)
        //{
        //    List<TEntity> result;
        //    using (TContext context = new TContext())
        //    {
        //        result = await context.Set<TEntity>().Where(filter).ToListAsync();
        //    }
        //    return result;
        //}

        public async Task<bool> UpdateAsync(TEntity entity, DateTime? guncellemeZamani = null)
        {
            bool result = false;
            using (TContext context = new TContext())
            {
                if (entity.isIdNotEmpty())
                {
                    entity.guncellemeZamani = guncellemeZamani != null ? (DateTime)guncellemeZamani : DateTime.Now;

                    context.Entry(entity).State = EntityState.Modified;
                    int response = await context.SaveChangesAsync();

                    if (response > 0)
                        result = true;
                }
            }
            return result;
        }
    }
}
