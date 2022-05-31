using AdminPanel.EntityLayer.Abctract;

namespace AdminPanle.BusinessLayer.Abstract.Base
{
    // iş katmanı genel arayüzü
    public interface IEntityBusBase<TEntity>
        where TEntity : IEntity, new ()
    {
        #region Getirme işlemleri
        
        /// <summary>
        /// Liste olarak getirme 
        /// </summary>
        /// <returns></returns>
        Task<List<TEntity>> GetAllAsync();
        
        /// <summary>
        /// id ye göre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> GetByIdAsync(int id);
        #endregion

        #region Silme işlemleri

        /// <summary>
        /// Liste olarak siler
        /// sonuç başarılı ise true döndürür
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<bool> Delete(List<TEntity> entities);

        /// <summary>
        /// id olarak siler
        /// sonuç başarılı ise true döndürür
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Delete(int id);

        /// <summary>
        /// Göderilmiş olan nesneye göre siler
        /// sonuç başarılı ise true döndürür
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> Delete(TEntity entity);
        #endregion

        #region Güncelleme işlemleri

        /// <summary>
        /// Güncelleme işlemi yapar
        /// işlem başarılı ise true diğer durumlarda false
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> Update(TEntity entity);

        /// <summary>
        /// Güncelleme işlemi yapar
        /// işlem başarılı ise nesneyi döndürür
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> UpdateBy(TEntity entity);
        #endregion

        #region Ekleme işlemleri
        /// <summary>
        /// Ekleme işlemi yapar teknesne için
        /// sonuç başarılı ise true döndürür
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> Add(TEntity entity);

        /// <summary>
        /// Liste olarak ekler
        /// sonuç başarılı ise true döndürür
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> Add(List<TEntity> entity);

        /// <summary>
        /// Ekleme işlemi yapar işlem başarılı ise kayıtlı halini geri dödürür
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> AddBy(TEntity entity);
        #endregion
    }
}
