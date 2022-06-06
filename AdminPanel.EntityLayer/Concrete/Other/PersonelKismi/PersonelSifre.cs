using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.PersonelKismi
{
    [Table("PersonelSifreleri")]
    public class PersonelSifre : EntityBase
    {
        public virtual Personel personel { get; set; }
        public string sifre { get; set; }
    }
}
