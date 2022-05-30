using AdminPanel.EntityLayer.Concrete.Base;
using AdminPanel.EntityLayer.Concrete.Other.IletisimKismi;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.FirmaKismi
{
    [Table("Firmalar")]
    public class Firma : EntityBase
    {
        public string adi { get; set; }
        public string logoURL { get; set; }
        public virtual Iletisim iletisim { get; set; }
    }
}
