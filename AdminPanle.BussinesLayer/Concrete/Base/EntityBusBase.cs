using AdminPanel.DataAccessLayer.Abstract.Base;
using AdminPanel.EntityLayer.Abctract;
using AdminPanle.BusinessLayer.Abstract.Base;

namespace AdminPanle.BusinessLayer.Concrete.Base
{
    public class EntityBusBase<TEntity> : IEntityBusBase<TEntity>
        where TEntity : class, IEntity, new()
    {
        IEntityDalBase<TEntity> _entityDalBase;
        public EntityBusBase(IEntityDalBase<TEntity> entityDalBase)
        {
            _entityDalBase = entityDalBase;
        }

        #region Ekleme işlemleri
        public async Task<bool> Add(TEntity entity)
        {
            bool result = false;

            if (entity.isIdEmpty())
            {
                try
                {
                    result = await _entityDalBase.AddAsync(entity);
                }
                catch
                {
                    result=false;
                }
            }

            return result;
        }

        public async Task<bool> Add(List<TEntity> entities)
        {
            bool result = true;
            if(entities != null && entities.Count() > 0)
            {
                foreach (TEntity entity in entities)
                {
                    result = await Add(entity);
                    if (!result)
                        break;
                }
            }
            else
                result = false;
            

            return result;
        }

        public async Task<TEntity?> AddBy(TEntity entity)
        {
            TEntity? result = null;
            if (entity.isNotNull())
            {
                DateTime dateTime = DateTime.Now;
                entity.kayitZamani = dateTime;

                if (await _entityDalBase.AddAsync(entity))
                    result = (await _entityDalBase.GetAsync(e => e.kayitZamani == dateTime)).FirstOrDefault();
            }
            return result;
        }
        #endregion
        #region daha yapılmadı
        public Task<bool> Delete(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateBy(TEntity entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
