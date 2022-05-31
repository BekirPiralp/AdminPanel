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
                
                if (await _entityDalBase.AddAsync(entity,dateTime))
                    result = (await _entityDalBase.GetAsync(e => e.kayitZamani == dateTime)).FirstOrDefault();
            }
            return result;
        }
        #endregion

        #region Sİlme işlemleri
        public async Task<bool> Delete(List<TEntity> entities)
        {
            bool result = false;
            if(entities != null && entities.Count() > 0)
            {
                result = true;
                foreach(TEntity entity in entities)
                {
                    result = await Delete(entity);
                    if (!result)
                        break;
                }
            }
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            bool result = false;
            if (id > 0)
            {
                TEntity? entity =(await _entityDalBase.GetAsync(e => e.id == id)).FirstOrDefault();
                if (entity.isNotNull())
                    result = await Delete(entity);
            }

            return result;
        }

        public async Task<bool> Delete(TEntity entity)
        {
            bool result = false;
            if (entity.isIdNotEmpty())
            {
                result = await _entityDalBase.DeleteAsync(entity);
            }
            return result;
        }
        #endregion

        #region daha yapılmadı
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
