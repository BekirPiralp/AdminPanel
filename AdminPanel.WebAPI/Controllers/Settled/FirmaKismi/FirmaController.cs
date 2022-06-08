using AdminPanel.EntityLayer.Concrete.Other.FirmaKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.FirmaKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.FirmaKismi
{
    public class FirmaController : BaseController<IBusFirma, Firma>
    {
        public FirmaController(IBusFirma entityBusBase) : base(entityBusBase)
        {
        }
    }
}
