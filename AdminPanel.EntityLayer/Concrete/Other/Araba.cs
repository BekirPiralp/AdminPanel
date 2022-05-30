using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    [Table(name: "Arabalar")]
    public class Araba : EntityBase
    {
        public virtual ArabaTip tip { get; set; }
        public virtual ArabaMarka marka { get; set; }
        public virtual ArabaKasaTip kasaTip { get; set; }
        public string model { get; set; }
        public string resimURL { get; set; }
        public int uretimYili { get; set; }
        public virtual ArabaVitesTip vitesTip { get; set; }
        public double gunlukFiyat { get; set; }
    }
}
