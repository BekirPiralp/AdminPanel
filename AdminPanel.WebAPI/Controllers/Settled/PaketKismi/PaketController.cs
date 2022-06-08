using AdminPanel.EntityLayer.Concrete.Other.PaketKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.PaketKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.PaketKismi
{
    public class PaketController : BaseController<IBusPaket, Paket>
    {
        public PaketController() : base(BusOlusturucu.Olustur().Paket)
        {
        }
    }
}
