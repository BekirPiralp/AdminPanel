using AdminPanel.EntityLayer.Concrete.Other.FirmaKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.FirmaKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.FirmaKismi
{
    public class BayiYoneticiController : BaseController<IBusBayiYonetici, BayiYonetici>
    {
        public BayiYoneticiController() : base(BusOlusturucu.Olustur().BayiYonetici)
        {
        }
    }
}
