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
                    int response = context.SaveChanges();
                    
                    if (response > 0)
                        result = true;
                }
            }
                return result;
        }
        #region yazılmadı
        public Task<bool> DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
