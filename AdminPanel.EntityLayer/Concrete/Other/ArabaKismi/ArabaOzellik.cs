using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.ArabaKismi
{
    [Table("ArabaOzellikleri")]
    public class ArabaOzellik : EntityBase
    {
        public string isim { get; set; }
    }
}
