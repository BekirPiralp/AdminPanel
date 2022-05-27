using AdminPanel.DataAccessLayer.Abstract.Other.EntityFramework;
using AdminPanel.EntityLayer.Abctract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework
{
    public class EntityEfDal<TEntity, TContext> : IEntityEfDalBase<TEntity>
        where TEntity : class, IEntity , new()
        where TContext : DbContext, new()
    {

        public async Task<bool> AddAsync(TEntity entity)
        {
            bool result = false;
            using (TContext context = new TContext()) {
                if (!entity.isNull())
                {
                    context.Entry(entity).State = EntityState.Added;
                    int response = await context.SaveChangesAsync();
                    
                    if (response > 0)
                        result = true;
                }
            }
            return result;
        }
        
        public async Task<bool> DeleteAsync(TEntity entity)
        {
            bool result = false;
            using (TContext context = new TContext())
            {
                if (!entity.isIdEmpty() & entity.silinmisMi())
                {
                    context.Entry(entity).State = EntityState.Deleted;
                    int response = await context.SaveChangesAsync();

                    if (response > 0)
                        result = true;
                }
            }
            return result;
        }
        
        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            List<TEntity> result;
            using (TContext context = new TContext()) {
                result = filter == null ? await context.Set<TEntity>().ToListAsync() 
                    : await context.Set<TEntity>().Where(filter).ToListAsync();
            }
            return result;
        }

        public async Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            List<TEntity> result;
            using (TContext context = new TContext())
            {
                result = await context.Set<TEntity>().Where(filter).ToListAsync();
            }
            return result;
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            bool result = false;
            using (TContext context = new TContext())
            {
                if (!entity.isIdEmpty())
                {
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
