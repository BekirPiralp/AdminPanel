using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class FirmaSahip :EntityBase
    {
        public Firma firma { get; set; }
        public Personel personel { get; set; }
    }
}
