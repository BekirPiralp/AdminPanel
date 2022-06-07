using AdminPanel.EntityLayer.Concrete.Other.ArabaKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.ArabaKismi
{
    public class ArabaAitOzellikController : BaseController<IBusArabaAitOzellik, ArabaAitOzellik>
    {
        public ArabaAitOzellikController() : base(BusOlusturucu.Olustur().ArabaAitOzellik)
        {
        }
    }
}
