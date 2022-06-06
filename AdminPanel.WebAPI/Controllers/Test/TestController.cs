using AdminPanel.EntityLayer.Concrete.Other.ArabaKismi;
using AdminPanel.EntityLayer.Concrete.Other.LogoKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.LogoKismi;
using AdminPanle.BusinessLayer.Other;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.WebAPI.Controllers.Test
{
    //[Route("test")]
    public class TestController : BaseController<IBusSosyalMedyaLogo, SosyalMedyaLogo>
    {
        
        public TestController() : base(BusOlusturucu.Olustur().SosyalMedyaLogo)
        {

        }
    }
}
