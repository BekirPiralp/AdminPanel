using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class IpucuVeYazi:EntityBase
    {
        public string baslik { get; set; }
        public string icerik { get; set; }
        public string logoURL { get; set; }
        public DateTime tarih { get; set; }
    }
}
