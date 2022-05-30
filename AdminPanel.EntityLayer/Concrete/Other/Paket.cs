using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("Paketler")]
    public class Paket: EntityBase
    {
        public string isim { get; set; }
        public double fiyat { get; set; }
    }
}
