using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.ArabaKismi
{
    [Serializable]
    [Table("ArabaOzellikleri")]
    public class ArabaOzellik : EntityBase
    {
        [MaxLength(length:100)]
        public string isim { get; set; }
    }
}
