using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Order
{
    public class PersonelGorev : EntityBase
    {
        public int personel { get; set; }
        public string isim { get; set; }
        public string tanim { get; set; }
    }
}
