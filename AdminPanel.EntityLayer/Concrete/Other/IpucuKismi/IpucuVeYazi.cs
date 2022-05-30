using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.IpucuKismi
{
    [Table("IpucuVeYazilar")]
    public class IpucuVeYazi : EntityBase
    {
        public string baslik { get; set; }
        public string icerik { get; set; }
        public string logoURL { get; set; }
        public DateTime tarih { get; set; }
    }
}
