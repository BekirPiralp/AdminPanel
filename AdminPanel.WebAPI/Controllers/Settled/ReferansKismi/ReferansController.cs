using AdminPanel.EntityLayer.Concrete.Other.ReferansKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.ReferansKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.ReferansKismi
{
    public class ReferansController : BaseController<IBusReferans, Referans>
    {
        public ReferansController() : base(BusOlusturucu.Olustur().Referans)
        {
        }
    }
}
