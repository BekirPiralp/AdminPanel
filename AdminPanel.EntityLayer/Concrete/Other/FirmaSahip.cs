using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("FirmaSahipleri")]
    public class FirmaSahip :EntityBase
    {
        public virtual Firma firma { get; set; }
        public virtual Personel personel { get; set; }
    }
}
