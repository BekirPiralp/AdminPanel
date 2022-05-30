using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("Firmalar")]
    public class Firma:EntityBase
    {
        public string adi { get; set; }
        public string logoURL { get; set; }
        public Iletisim iletisim { get; set; }
    }
}
