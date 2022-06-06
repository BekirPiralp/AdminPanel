using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.HakkindaKismi
{
    [Serializable]
    [Table("HakkindaReklamlar")]
    public class HakkindaReklam : EntityBase
    {
        public string baslik { get; set; }
        public string icerik { get; set; }
        /// <summary>
        /// Logosu daha belirlenmemiş olabilir
        /// </summary>
        public string? logoURL { get; set; }
    }
}
