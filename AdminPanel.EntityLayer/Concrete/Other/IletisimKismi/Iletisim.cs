using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.IletisimKismi
{
    [Table("Iletisimleri")]
    public class Iletisim : EntityBase
    {
        public string adres { get; set; }
        public string eposta { get; set; }
        public string tel { get; set; }
    }
}
