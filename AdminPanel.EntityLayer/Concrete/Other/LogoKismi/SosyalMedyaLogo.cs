using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.LogoKismi
{
    [Table("SosyalMedyaLogolari")]
    public class SosyalMedyaLogo : EntityBase
    {
        public string logoURL { get; set; }
    }
}
