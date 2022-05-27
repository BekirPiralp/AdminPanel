using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class Musteri : EntityBase
    {
        public int firma { get; set; }
        public string tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
    }
}
