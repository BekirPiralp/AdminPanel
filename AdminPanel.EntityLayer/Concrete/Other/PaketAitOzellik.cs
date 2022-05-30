using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("PaketAitOzellikleri")]
    public class PaketAitOzellik : EntityBase
    {
        public Paket paket { get; set; }
        public PaketOzellik ozellik { get; set; }
    }
}
