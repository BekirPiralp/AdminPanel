using AdminPanel.EntityLayer.Concrete.Other.IpucuKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.IpucuKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.IpucuVeYaziKismi
{
    public class IpucuVeYaziController : BaseController<IBusIpucuVeYazi, IpucuVeYazi>
    {
        public IpucuVeYaziController() : base(BusOlusturucu.Olustur().IpucuVeYazi)
        {
        }
    }
}
