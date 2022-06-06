using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.ReferansKismi
{
    [Serializable]
    [Table("Referanslar")]
    public class Referans : EntityBase
    {
        public string adi { get; set; }
        public string icerik { get; set; }
        /// <summary>
        /// Referansın remi yüklenmemiş olabilir
        /// </summary>
        public string? resimURL { get; set; }
    }
}
