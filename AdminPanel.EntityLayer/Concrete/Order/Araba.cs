using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Order
{
    public class Araba : EntityBase
    {
        public int tip { get; set; }
        public int marka { get; set; }
        public int kasaTip { get; set; }
        public string model { get; set; }
        public string resimURL { get; set; }
        public int uretimYili { get; set; }
        public int vitesTip { get; set; }
        public double gunlukFiyat { get; set; }
    }
}
