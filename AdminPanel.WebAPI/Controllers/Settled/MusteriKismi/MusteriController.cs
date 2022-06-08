using AdminPanel.EntityLayer.Concrete.Other.MusteriKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.MusteriKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.MusteriKismi
{
    public class MusteriController : BaseController<IBusMusteri, Musteri>
    {
        public MusteriController() : base(BusOlusturucu.Olustur().Musteri)
        {
        }
    }
}
