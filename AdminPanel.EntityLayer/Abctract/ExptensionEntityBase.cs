
namespace AdminPanel.EntityLayer.Abctract
{
    public static class ExptensionEntityBase
    {
        /// <summary>
        /// silinip slinmeme durumu:
        /// silimiş ise true diğer tüm durumlarda false
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static bool silinmisMi(this IEntity entity)
        {
            return !entity.isNull() && entity.sil;
        }

        /// <summary>
        /// null ise true diğer durumda false
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static bool isNull(this IEntity? entity) => entity == null;

        /// <summary>
        /// id atalı ise false değil ise true
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static bool isIdEmpty(this IEntity entity) => !(!entity.isNull() && entity.id > 0);
    }
}
