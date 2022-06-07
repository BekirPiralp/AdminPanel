﻿using AdminPanel.EntityLayer.Concrete.Other.BolumBilgileri;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Other;


namespace AdminPanel.WebAPI.Controllers.Settled.BolumBilgileri
{
    public class HakkindaBolumBilgisiController : BaseController<IBusHakkindaBolumBilgisi, HakkindaBolumBilgisi>
    {
        public HakkindaBolumBilgisiController() : base(BusOlusturucu.Olustur().HakkindaBolumBilgisi)
        {
        }
    }
}