using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("ArabaVitesTipleri")]
    public class ArabaVitesTip : EntityBase
    {
        public string isim { get; set; }
    }
}
