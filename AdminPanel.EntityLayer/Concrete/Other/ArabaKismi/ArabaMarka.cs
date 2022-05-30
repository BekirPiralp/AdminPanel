using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.ArabaKismi
{
    [Table("ArabaMarkalari")]
    public class ArabaMarka : EntityBase
    {
        public string isim { get; set; }
    }
}
