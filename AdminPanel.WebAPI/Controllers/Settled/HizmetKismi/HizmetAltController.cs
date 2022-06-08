using AdminPanel.EntityLayer.Concrete.Other.HizmetKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.HizmetKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.HizmetKismi
{
    public class HizmetAltController : BaseController<IBusHizmetAlt, HizmetAlt>
    {
        public HizmetAltController() : base(BusOlusturucu.Olustur().HizmetAlt)
        {
        }
    }
}
