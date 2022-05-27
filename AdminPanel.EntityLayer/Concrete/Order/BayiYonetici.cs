using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Order
{
    public class BayiYonetici : EntityBase
    {
        public int firma { get; set; }
        public int bayi { get; set; }
        public int personel { get; set; }
    }
}
