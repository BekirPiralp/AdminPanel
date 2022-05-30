using AdminPanel.EntityLayer.Concrete.Base;
using AdminPanel.EntityLayer.Concrete.Other.LogoKismi;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.PersonelKismi
{
    [Table("PersonelSosyalMedyalari")]
    public class PersonelSosyalMedya : EntityBase
    {
        public virtual Personel personel { get; set; }
        public string sosyalMedyaURL { get; set; }
        public virtual SosyalMedyaLogo sosyalMedyaLogo { get; set; }
    }
}
