using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class Bayi : EntityBase
    {
        public Firma firma { get; set; }
        public string isim { get; set; }
        public Iletisim iletisim { get; set; }
    }
}
