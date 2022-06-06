using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.PaketKismi
{
    [Table("PaketAitOzellikleri")]
    public class PaketAitOzellik : EntityBase
    {
        public virtual Paket paket { get; set; }
        public virtual PaketOzellik ozellik { get; set; }
    }
}
