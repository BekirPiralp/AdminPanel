using AdminPanel.DataAccessLayer.Abstract.Other.Genel.IpucuKismi;
using AdminPanel.EntityLayer.Concrete.Other.IpucuKismi;
using AdminPanle.BusinessLayer.Abstract.Other.IpucuKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.IpucuKismi
{
    public class BusIpucuVeYazi : EntityBusBase<IpucuVeYazi>, IBusIpucuVeYazi
    {
        public BusIpucuVeYazi(IDalIpucuVeYazi entityDalBase) : base(entityDalBase)
        {
        }
    }
}
