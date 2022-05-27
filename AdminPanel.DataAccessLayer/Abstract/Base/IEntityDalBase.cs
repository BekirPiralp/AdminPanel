using AdminPanel.EntityLayer.Abctract;
using System.Linq.Expressions;

namespace AdminPanel.DataAccessLayer.Abstract.Base
{
    public interface IEntityDalBase<TEntity> 
        where TEntity : class, IEntity
    {
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
        Task<bool> DeleteAsync(int id);

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
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<List<TEntity>> GetAllAsync();

        /// <summary>
        /// Getirme işlemi yapar 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<List<TEntity>> GetByFilterAsync(Expression<Func<TEntity,bool>> filter);
        #endregion

    }
}
