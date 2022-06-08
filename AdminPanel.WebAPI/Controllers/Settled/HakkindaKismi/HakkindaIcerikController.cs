using AdminPanel.EntityLayer.Concrete.Other.HakkindaKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.HakkindaKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.HakkindaKismi
{
    public class HakkindaIcerikController : BaseController<IBusHakkindaIcerik, HakkindaIcerik>
    {
        public HakkindaIcerikController() : base(BusOlusturucu.Olustur().HakkindaIcerik)
        {
        }
    }
}
