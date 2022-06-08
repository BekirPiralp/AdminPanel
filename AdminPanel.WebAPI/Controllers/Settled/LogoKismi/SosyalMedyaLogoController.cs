using AdminPanel.EntityLayer.Concrete.Other.LogoKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.LogoKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.LogoKismi
{
    public class SosyalMedyaLogoController : BaseController<IBusSosyalMedyaLogo, SosyalMedyaLogo>
    {
        public SosyalMedyaLogoController() : base(BusOlusturucu.Olustur().SosyalMedyaLogo)
        {
        }
    }
}
