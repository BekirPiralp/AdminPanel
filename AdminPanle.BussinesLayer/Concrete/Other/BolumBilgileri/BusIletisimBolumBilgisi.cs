using AdminPanel.DataAccessLayer.Abstract.Other.Genel.BolumBilgileri;
using AdminPanel.EntityLayer.Concrete.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Abstract.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.BolumBilgileri
{
    public class BusIletisimBolumBilgisi : EntityBusBase<IletisimBolumBilgisi>, IBusIletisimBolumBilgisi
    {
        public BusIletisimBolumBilgisi(IDalIletisimBolumBilgisi entityDalBase) : base(entityDalBase)
        {
        }
    }
}
