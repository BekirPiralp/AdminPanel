using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("PersonelGorevleri")]
    public class PersonelGorev : EntityBase
    {
        public Personel personel { get; set; }
        public string isim { get; set; }
        public string tanim { get; set; }
    }
}
