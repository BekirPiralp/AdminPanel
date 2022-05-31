
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
            //deneme
            _entityDalBase = entityDalBase;
        }

        #region Ekleme işlemleri
        public async Task<bool> AddAsync(TEntity entity)
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

        public async Task<bool> AddAsync(List<TEntity> entities)
        {
            bool result = true;
            if(entities != null && entities.Count() > 0)
            {
                foreach (TEntity entity in entities)
                {
                    result = await AddAsync(entity);
                    if (!result)
                        break;
                }
            }
            else
                result = false;
            

            return result;
        }

        public async Task<TEntity?> AddByAsync(TEntity entity)
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

        #region Silme işlemleri
        public async Task<bool> DeleteAsync(List<TEntity> entities)
        {
            bool result = false;
            if(entities != null && entities.Count() > 0)
            {
                result = true;
                foreach(TEntity entity in entities)
                {
                    result = await DeleteAsync(entity);
                    if (!result)
                        break;
                }
            }
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            bool result = false;
            if (id > 0)
            {
                TEntity? entity =(await _entityDalBase.GetAsync(e => e.id == id)).FirstOrDefault();
                if (entity.isNotNull() && !entity.silinmisMi())
                    result = await _entityDalBase.DeleteAsync(entity);
            }

            return result;
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            bool result = false;
            if (entity.isIdNotEmpty())
            {
                result = await _entityDalBase.DeleteAsync(entity);
            }
            return result;
        }
        #endregion

        #region Getirme işlemleri
        public async Task<List<TEntity>?> GetAllAsync()
        {
            List<TEntity>? result;
            result = await _entityDalBase.GetAsync();
            
            if (result != null && result.Count < 0)
                result = null;
            
            return result;
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            TEntity? result = null;
            if (id > 0)
                result = (await _entityDalBase.GetAsync(e => e.id == id)).FirstOrDefault();
            return result;
        }
        #endregion

        #region Güncellem İşlemleri
        public async Task<bool> UpdateAsync(TEntity entity)
        {
            bool result = false;
            if (entity.isNotNull() && entity.isIdNotEmpty())
                result = await _entityDalBase.UpdateAsync(entity);
            return result;
        }

        public async Task<TEntity?> UpdateByAsync(TEntity entity)
        {
            TEntity? result = null;
            if (entity.isNotNull() && entity.isIdNotEmpty())
            {
                DateTime dateTime = DateTime.Now;
                entity.guncellemeZamani = dateTime;

                if(await _entityDalBase.UpdateAsync(entity))
                {
                    result = (await _entityDalBase.GetAsync(
                        e => e.guncellemeZamani == dateTime && 
                        e.id == entity.id)).FirstOrDefault();
                }
            }
            return result;
        }
        #endregion
    }
}
