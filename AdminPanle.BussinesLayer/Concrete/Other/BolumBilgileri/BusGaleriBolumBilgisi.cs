using AdminPanel.DataAccessLayer.Abstract.Other.Genel.BolumBilgileri;
using AdminPanel.EntityLayer.Concrete.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Abstract.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.BolumBilgileri
{
    public class BusGaleriBolumBilgisi : EntityBusBase<GaleriBolumBilgisi>, IBusGaleriBolumBilgisi
    {
        public BusGaleriBolumBilgisi(IDalGaleriBolumBilgisi entityDalBase) : base(entityDalBase)
        {
        }
    }
}
