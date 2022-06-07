using AdminPanel.EntityLayer.Concrete.Other.ArabaKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.ArabaKismi
{
    public class ArabaController : BaseController<IBusAraba, Araba>
    {
        public ArabaController() : base(BusOlusturucu.Olustur().Araba)
        {
        }
    }
}
