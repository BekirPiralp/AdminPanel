using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.PaketKismi
{
    [Table("PaketOzellikleri")]
    public class PaketOzellik : EntityBase
    {
        public string isim { get; set; }
    }
}
