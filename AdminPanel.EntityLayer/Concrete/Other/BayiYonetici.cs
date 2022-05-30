using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("BayiYoneticileri")]
    public class BayiYonetici : EntityBase
    {
        public Firma firma { get; set; }
        public Bayi bayi { get; set; }
        public Personel personel { get; set; }
    }
}
