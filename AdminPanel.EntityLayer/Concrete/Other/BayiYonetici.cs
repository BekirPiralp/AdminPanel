using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("BayiYoneticileri")]
    public class BayiYonetici : EntityBase
    {
        public virtual Firma firma { get; set; }
        public virtual Bayi bayi { get; set; }
        public virtual Personel personel { get; set; }
    }
}
