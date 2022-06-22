using AdminPanel.EntityLayer.Concrete.Other.LogoKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.LogoKismi;
using AdminPanle.BusinessLayer.Other;

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
