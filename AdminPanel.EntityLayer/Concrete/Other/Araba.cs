﻿using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Other
{
    public class Araba : EntityBase
    {
        public ArabaTip tip { get; set; }
        public ArabaMarka marka { get; set; }
        public ArabaKasaTip kasaTip { get; set; }
        public string model { get; set; }
        public string resimURL { get; set; }
        public int uretimYili { get; set; }
        public ArabaVitesTip vitesTip { get; set; }
        public double gunlukFiyat { get; set; }
    }
}
