using AdminPanel.DataAccessLayer.Abstract.Other.Genel.BolumBilgileri;
using AdminPanel.EntityLayer.Concrete.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Abstract.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.BolumBilgileri
{
    public class BusIpucuVeYaziBolumBilgisi : EntityBusBase<IpucuVeYaziBolumBilgisi>, IBusIpucuVeYaziBolumBilgisi
    {
        public BusIpucuVeYaziBolumBilgisi(IDalIpucuVeYaziBolumBilgisi entityDalBase) : base(entityDalBase)
        {
        }
    }
}
