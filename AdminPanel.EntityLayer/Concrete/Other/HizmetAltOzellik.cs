using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("HizmetAltOzellikler")]
    public class HizmetAltOzellik : EntityBase
    {
        public virtual HizmetAlt hizmetAlt { get; set; }
        public string isim { get; set; }
    }
}
