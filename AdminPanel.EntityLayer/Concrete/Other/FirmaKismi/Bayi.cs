using AdminPanel.EntityLayer.Concrete.Base;
using AdminPanel.EntityLayer.Concrete.Other.IletisimKismi;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.FirmaKismi
{
    [Table("Bayiler")]
    public class Bayi : EntityBase
    {
        public virtual Firma firma { get; set; }
        public string isim { get; set; }
        public virtual Iletisim? iletisim { get; set; }
    }
}
