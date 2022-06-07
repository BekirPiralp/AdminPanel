using AdminPanel.EntityLayer.Concrete.Other.BolumBilgileri;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Other;


namespace AdminPanel.WebAPI.Controllers.Settled.BolumBilgileri
{
    public class IletisimBolumBilgisiController : BaseController<IBusIletisimBolumBilgisi, IletisimBolumBilgisi>
    {
        public IletisimBolumBilgisiController() : base(BusOlusturucu.Olustur().IletisimBolumBilgisi)
        {
        }
    }
}
