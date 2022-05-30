using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("ArabaTipleri")]
    public class ArabaTip : EntityBase
    {
        public string isim { get; set; }
    }
}
