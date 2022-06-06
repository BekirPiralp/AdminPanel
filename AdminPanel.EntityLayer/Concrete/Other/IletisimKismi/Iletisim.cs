using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.IletisimKismi
{
    [Serializable]
    [Table("Iletisimleri")]
    public class Iletisim : EntityBase
    {
        /// <summary>
        /// adersi olmaya bilir. çift eposta veya çift tel gibi ...
        /// </summary>
        public string? adres { get; set; }
        /// <summary>
        /// epostası olmaya bilir. çift adres veya çift tel olabilir
        /// </summary>
        public string? eposta { get; set; }
        /// <summary>
        /// Tel olmaya bilir. Çift adres veya çift eposta olabilir
        /// </summary>
        public string? tel { get; set; }

    }
}
