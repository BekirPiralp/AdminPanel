using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("Bayiler")]
    public class Bayi : EntityBase
    {
        public Firma firma { get; set; }
        public string isim { get; set; }
        public Iletisim iletisim { get; set; }
    }
}
