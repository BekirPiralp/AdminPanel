using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class Mesaj : EntityBase
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string eposta { get; set; }
        public string konu { get; set; }
        public string icerik { get; set; }
    }
}
