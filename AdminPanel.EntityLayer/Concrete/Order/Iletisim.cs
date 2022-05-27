using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Order
{
    public class Iletisim : EntityBase
    {
        public string adres { get; set; }
        public string eposta { get; set; }
        public string tel { get; set; }
    }
}
