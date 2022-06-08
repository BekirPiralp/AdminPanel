using AdminPanel.EntityLayer.Concrete.Other.PaketKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.PaketKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.PaketKismi
{
    public class PaketAitOzellikController : BaseController<IBusPaketAitOzellik, PaketAitOzellik>
    {
        public PaketAitOzellikController() : base(BusOlusturucu.Olustur().PaketAitOzellik)
        {
        }
    }
}
