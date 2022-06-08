using AdminPanel.EntityLayer.Concrete.Other.IletisimKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.IletisimKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.IletisimKismi
{
    public class IletisimController : BaseController<IBusIletisim, Iletisim>
    {
        public IletisimController() : base(BusOlusturucu.Olustur().Iletisim)
        {
        }
    }
}
