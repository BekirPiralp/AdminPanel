using AdminPanel.EntityLayer.Concrete.Other.HizmetKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.HizmetKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.HizmetKismi
{
    public class HizmetAltOzellikController : BaseController<IBusHizmetAltOzellik, HizmetAltOzellik>
    {
        public HizmetAltOzellikController() : base(BusOlusturucu.Olustur().HizmetAltOzellik)
        {
        }
    }
}
