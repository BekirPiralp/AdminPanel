using AdminPanel.EntityLayer.Concrete.Other.ArabaKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.ArabaKismi
{
    public class ArabaVitesTipController : BaseController<IBusArabaVitesTip, ArabaVitesTip>
    {
        public ArabaVitesTipController() : base(BusOlusturucu.Olustur().ArabaVitesTip)
        {
        }
    }
}
