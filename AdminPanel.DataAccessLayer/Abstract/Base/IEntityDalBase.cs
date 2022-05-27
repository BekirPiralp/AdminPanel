using AdminPanel.EntityLayer.Abctract;
using System.Linq.Expressions;

namespace AdminPanel.DataAccessLayer.Abstract.Base
{
    public interface IEntityDalBase<TEntity> 
        where TEntity : class, IEntity, new()
    {//Kübra
        /***
         * sil delete
         * guncelle udpdate
         * ekle add
         * getir get
         */
        /// <summary>
        /// Silme işlemi yapar 
        /// sonuc başarılı ise true diğer durumlarda false
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(TEntity entity);

        /// <summary>
        /// Güncelleme işlemi yapar 
        /// sonuc başarılı ise true diğer durumlarda false
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(TEntity entity);

        /// <summary>
        /// Ekleme işlemi yapar 
        /// sonuc başarılı ise true diğer durumlarda false
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> AddAsync(TEntity entity);

        #region getirme işlemleri
        /// <summary>
        /// Getirme işlemi yapar 
        /// Filtreye göre
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Getirme işlemi yapar 
        /// Duruma göre ;)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null);
        #endregion

    }
}
