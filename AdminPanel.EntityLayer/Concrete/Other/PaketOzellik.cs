using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("PaketOzellikleri")]
    public class PaketOzellik:EntityBase
    {
        public string isim { get; set; }
    }
}
