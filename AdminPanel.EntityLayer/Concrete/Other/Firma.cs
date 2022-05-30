using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class Firma:EntityBase
    {
        public string adi { get; set; }
        public string logoURL { get; set; }
        public Iletisim iletisim { get; set; }
    }
}
