using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.HizmetKismi
{
    [Table("Hizmetler")]
    public class Hizmet : EntityBase
    {
        public string isim { get; set; }
        public string tanim { get; set; }
        public string logoURL { get; set; }
        public string resimURL { get; set; }
    }
}
