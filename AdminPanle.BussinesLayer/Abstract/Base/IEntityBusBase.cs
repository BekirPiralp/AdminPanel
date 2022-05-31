using AdminPanel.EntityLayer.Abctract;

namespace AdminPanle.BusinessLayer.Abstract.Base
{
    // iş katmanı genel arayüzü
    public interface IEntityBusBase<TEntity>
        where TEntity : IEntity, new ()
    {
        #region Getirme işlemleri
        /**
         * Sil durumuna bakmaksızın geliyor
         */ 

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
    }
}
