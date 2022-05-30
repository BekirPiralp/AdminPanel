using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("Referanslar")]
    public class Referans:EntityBase
    {
        public string adi { get; set; }
        public string icerik { get; set; }
        public string resimURL { get; set; }
    }
}
