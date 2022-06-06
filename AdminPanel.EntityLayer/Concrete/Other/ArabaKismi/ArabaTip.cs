using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.ArabaKismi
{
    [Table("ArabaTipleri")]
    public class ArabaTip : EntityBase
    {
        public string isim { get; set; }
    }
}
