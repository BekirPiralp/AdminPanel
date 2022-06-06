using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.MesajKismi
{
    [Serializable]
    [Table("Mesajlar")]
    public class Mesaj : EntityBase
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string eposta { get; set; }
        public string konu { get; set; }
        public string icerik { get; set; }
    }
}
