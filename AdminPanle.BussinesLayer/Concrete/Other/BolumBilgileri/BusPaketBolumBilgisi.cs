using AdminPanel.DataAccessLayer.Abstract.Other.Genel.BolumBilgileri;
using AdminPanel.EntityLayer.Concrete.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Abstract.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.BolumBilgileri
{
    public class BusPaketBolumBilgisi : EntityBusBase<PaketBolumBilgisi>, IBusPaketBolumBilgisi
    {
        public BusPaketBolumBilgisi(IDalPaketBolumBilgisi entityDalBase) : base(entityDalBase)
        {
        }
    }
}
