using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("PersonelSosyalMedyalari")]
    public class PersonelSosyalMedya : EntityBase
    {
        public Personel personel { get; set; }
        public string sosyalMedyaURL { get; set; }
        public string sosyalMedyaLogo { get; set; }
    }
}
