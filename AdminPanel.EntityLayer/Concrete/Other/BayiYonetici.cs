using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class BayiYonetici : EntityBase
    {
        public Firma firma { get; set; }
        public Bayi bayi { get; set; }
        public Personel personel { get; set; }
    }
}
