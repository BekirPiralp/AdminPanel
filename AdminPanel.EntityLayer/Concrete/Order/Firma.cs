﻿using AdminPanel.EntityLayer.Concrete.Base;

namespace AdminPanel.EntityLayer.Concrete.Order
{
    public class Firma:EntityBase
    {
        public string adi { get; set; }
        public string logoURL { get; set; }
        public int iletisim { get; set; }
    }
}
