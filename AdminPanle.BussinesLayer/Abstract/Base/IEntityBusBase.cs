using AdminPanel.EntityLayer.Abctract;
using AdminPanle.BusinessLayer.Other.Response;

namespace AdminPanle.BusinessLayer.Abstract.Base
{
    // iş katmanı genel arayüzü
    // IEntityBusBase == InterfaceEntityBusinesLayerBase
    public interface IEntityBusBase<TEntity>
        where TEntity : class, IEntity, new()
    {
        #region Getirme işlemleri

        /// <summary>
        /// Liste olarak getirme 
        /// </summary>
        /// <returns></returns>
        Task<ObjectResponse<List<TEntity>>> GetAllAsync();

        /// <summary>
        /// id ye göre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ObjectResponse<TEntity>> GetByIdAsync(int id);
        #endregion

        #region Silme işlemleri

        /// <summary>
        /// Liste olarak siler
        /// sonuç başarılı ise true döndürür
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<ObjectResponse<object>> DeleteAsync(List<TEntity> entities);

        /// <summary>
        /// id olarak siler
        /// sonuç başarılı ise true döndürür
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ObjectResponse<object>> DeleteAsync(int id);

        /// <summary>
        /// Göderilmiş olan nesneye göre siler
        /// sonuç başarılı ise true döndürür
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<ObjectResponse<object>> DeleteAsync(TEntity entity);
        #endregion

        #region Güncelleme işlemleri

        /// <summary>
        /// Güncelleme işlemi yapar
        /// işlem başarılı ise true diğer durumlarda false
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(TEntity entity);

        /// <summary>
        /// Güncelleme işlemi yapar
        /// işlem başarılı ise nesneyi döndürür
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity?> UpdateByAsync(TEntity entity);
        #endregion

        #region Ekleme işlemleri
        /// <summary>
        /// Ekleme işlemi yapar teknesne için
        /// sonuç başarılı ise true döndürür
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<ObjectResponse<object>> AddAsync(TEntity entity);

        /// <summary>
        /// Liste olarak ekler
        /// sonuç başarılı ise true döndürür
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<ObjectResponse<object>> AddAsync(List<TEntity> entities);

        /// <summary>
        /// Ekleme işlemi yapar işlem başarılı ise kayıtlı halini geri dödürür
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<ObjectResponse<TEntity>> AddByAsync(TEntity entity);
        #endregion
    }
}
