using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("HakkindaIcerikleri")]
    public class HakkindaIcerik : EntityBase
    {
        public string icerik { get; set; }
        public string resimURL { get; set; }
    }
}
