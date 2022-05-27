namespace AdminPanel.EntityLayer.Concrete.Base
{
    public static class ExptensionEntityBase
    {
        /// <summary>
        /// silinip slinmeme durumu:
        /// silimiş ise true diğer tüm durumlarda false
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static bool silinmisMi(this EntityBase entity)
        {
            return !entity.isNull() && entity.sil;
        }

        /// <summary>
        /// null ise true diğer durumda false
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static bool isNull(this EntityBase? entity) => entity == null;

        /// <summary>
        /// id atalı ise false değil ise true
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static bool isIdEmpty(this EntityBase entity) => !(!entity.isNull() && entity.id > 0);
    }
}
