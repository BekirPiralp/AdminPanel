using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table("FirmaSahipleri")]
    public class FirmaSahip :EntityBase
    {
        public Firma firma { get; set; }
        public Personel personel { get; set; }
    }
}
