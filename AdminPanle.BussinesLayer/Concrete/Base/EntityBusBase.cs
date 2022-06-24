﻿
using AdminPanel.DataAccessLayer.Abstract.Base;
using AdminPanel.EntityLayer.Abctract;
using AdminPanle.BusinessLayer.Abstract.Base;
using AdminPanle.BusinessLayer.Other.Response;

namespace AdminPanle.BusinessLayer.Concrete.Base
{
    public class EntityBusBase<TEntity> : IEntityBusBase<TEntity>
        where TEntity : class, IEntity, new()
    {
        protected IEntityDalBase<TEntity> _entityDalBase;
        public EntityBusBase(IEntityDalBase<TEntity> entityDalBase)
        {
            //deneme
            _entityDalBase = entityDalBase;
        }

        #region Ekleme işlemleri
        public async Task<ObjectResponse<object>> AddAsync(TEntity entity)
        {
            ObjectResponse<object> result;
            //bool result = false;

            if (entity.isIdEmpty())
            {
                try
                {
                    if (await _entityDalBase.AddAsync(entity))
                        result = new ObjectResponse<object>(true);
                    else
                        result = new ObjectResponse<object>("Ekeleme işlemi başarısız");
                }
                catch (Exception ex)
                {
                    result = new ObjectResponse<object>("Eklemişleminde hata ile karşılaşıldı. :\n\t" + ex.Message);
                }
            }
            else
                result = new ObjectResponse<object>("Geçersiz parametre");

            return result;
        }

        public async Task<ObjectResponse<object>> AddAsync(List<TEntity> entities)
        {
            ObjectResponse<object> result;
            
            if (entities != null && entities.Count() > 0)
            {
                result = new ObjectResponse<object>(true);
                foreach (TEntity entity in entities)
                {

                    if (!(await _entityDalBase.AddAsync(entity)))
                    {
                        result = new ObjectResponse<object>("Liste ekleme işleminde ekelenemeyen nesneler oluştu");
                        break;
                    }
                }
            }
            else
                result = new ObjectResponse<object>("Geçersiz parametre");

            return result;
        }

        public async Task<ObjectResponse<TEntity>> AddByAsync(TEntity entity)
        {
            ObjectResponse<TEntity> result;
            if (entity.isNotNull())
            {
                DateTime dateTime = DateTime.Now;

                if (await _entityDalBase.AddAsync(entity, dateTime))
                    result = new ObjectResponse<TEntity>(
                        (await _entityDalBase.GetAsync()).FirstOrDefault(p => p.kayitZamani == dateTime));
                else
                    result = new ObjectResponse<TEntity>("Nesne eklenemedi");
            }
            else
                result = new ObjectResponse<TEntity>("Geçersiz parametre");

            return result;
        }
        #endregion

        #region Silme işlemleri
        public async Task<ObjectResponse<object>> DeleteAsync(List<TEntity> entities)
        {
            ObjectResponse<object> result;
            if (entities != null && entities.Count() > 0)
            {
                result = new ObjectResponse<object>(true);
                foreach (TEntity entity in entities)
                {

                    if (!await _entityDalBase.DeleteAsync(entity))
                    {
                        result = new ObjectResponse<object>("Silme işleminde silinemeyen nesneler oldu");
                        break;
                    }
                }
            }
            else
                result = new ObjectResponse<object>("Geçersiz parametre");
            return result;
        }

        public async Task<ObjectResponse<object>> DeleteAsync(int id)
        {
            ObjectResponse<object> result = new ObjectResponse<object>(true);
            if (id > 0)
            {
                TEntity? entity = (await _entityDalBase.GetAsync(e => e.Id == id)).FirstOrDefault();
                if (entity.isNotNull() && !entity.silinmisMi())
                {
                    if (!await _entityDalBase.DeleteAsync(entity))
                        result = new ObjectResponse<object>($"{id} li nesne silinemedi");
                }
                else
                    result = new ObjectResponse<object>("Nesne bulunamadı veya silinmiş");
            }
            else
                result = new ObjectResponse<object>("Geçersiz parametre");

            return result;
        }

        public async Task<ObjectResponse<object>> DeleteAsync(TEntity entity)
        {
            ObjectResponse<object> result;
            if (entity.isIdNotEmpty())
            {
                if (await _entityDalBase.DeleteAsync(entity))
                    result = new ObjectResponse<object>(true);
                else
                    result = new ObjectResponse<object>("Silme işlemi ilgili nesne için başarısız");
            }
            else
                result = new ObjectResponse<object>("Geçersiz parametre");
            return result;
        }
        #endregion

        #region Getirme işlemleri
        public async Task<ObjectResponse<List<TEntity>>> GetAllAsync()
        {
            ObjectResponse<List<TEntity>> result;
            var entities = await _entityDalBase.GetAsync();

            if (entities != null && entities.Count < 0)
                result = new ObjectResponse<List<TEntity>>("Veriler getirilemedi");
            else
                result = new ObjectResponse<List<TEntity>>(entities);

            return result;
        }

        public async Task<ObjectResponse<TEntity>> GetByIdAsync(int id)
        {
            ObjectResponse<TEntity> result ;
            if (id > 0)
                result = new ObjectResponse<TEntity>((await _entityDalBase.GetAsync(e => e.Id == id)).FirstOrDefault());
            else
                result = new ObjectResponse<TEntity>("Geçersiz parametre");
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

                if (await _entityDalBase.UpdateAsync(entity))
                {
                    result = (await _entityDalBase.GetAsync(
                        e => e.guncellemeZamani == dateTime &&
                        e.Id == entity.Id)).FirstOrDefault();
                }
            }
            return result;
        }
        #endregion
    }
}
