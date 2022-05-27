using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Order
{
    public class Hizmet : EntityBase
    {
        public string isim { get; set; }
        public string tanim { get; set; }
        public string logoURL { get; set; }
        public string resimURL { get; set; }
    }
}
