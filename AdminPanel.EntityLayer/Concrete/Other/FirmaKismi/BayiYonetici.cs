using AdminPanel.EntityLayer.Concrete.Base;
using AdminPanel.EntityLayer.Concrete.Other.PersonelKismi;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.FirmaKismi
{
    [Table("BayiYoneticileri")]
    public class BayiYonetici : EntityBase
    {
        public virtual Firma firma { get; set; }
        public virtual Bayi bayi { get; set; }
        /// <summary>
        /// henüz yöneticisi atanmamış olabilir
        /// </summary>
        public virtual Personel? personel { get; set; }
    }
}
