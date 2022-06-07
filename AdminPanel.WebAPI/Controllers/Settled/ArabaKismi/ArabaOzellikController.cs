using AdminPanel.EntityLayer.Concrete.Other.ArabaKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.ArabaKismi
{
    public class ArabaOzellikController : BaseController<IBusArabaOzellik, ArabaOzellik>
    {
        public ArabaOzellikController() : base(BusOlusturucu.Olustur().ArabaOzellik)
        {
        }
    }
}
