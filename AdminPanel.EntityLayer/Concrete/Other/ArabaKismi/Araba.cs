using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.ArabaKismi
{
    [Serializable]
    [Table(name: "Arabalar")]
    public class Araba : EntityBase
    {
        [Required]
        public virtual ArabaTip tip { get; set; }
        [Required]
        public virtual ArabaMarka marka { get; set; }
        [Required]
        public virtual ArabaKasaTip kasaTip { get; set; }
        [MaxLength(100)]
        public string model { get; set; }
        public string? resimURL { get; set; }
        public int uretimYili { get; set; }
        [Required]
        public virtual ArabaVitesTip vitesTip { get; set; }
        public double? gunlukFiyat { get; set; }
    }
}
