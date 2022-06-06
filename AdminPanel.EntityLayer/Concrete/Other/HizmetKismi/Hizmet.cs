using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.HizmetKismi
{
    [Serializable]
    [Table("Hizmetler")]
    public class Hizmet : EntityBase
    {
        public string isim { get; set; }
        public string tanim { get; set; }
        /// <summary>
        /// logosu oluşturulmamış olabilir
        /// </summary>
        public string? logoURL { get; set; }
        /// <summary>
        /// resimi oluşturulmamamış olabilir
        /// </summary>
        public string? resimURL { get; set; }
    }
}
