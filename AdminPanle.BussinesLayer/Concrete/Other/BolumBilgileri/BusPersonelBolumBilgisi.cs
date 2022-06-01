using AdminPanel.DataAccessLayer.Abstract.Other.Genel.BolumBilgileri;
using AdminPanel.EntityLayer.Concrete.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Abstract.Other.BolumBilgileri;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.BolumBilgileri
{
    public class BusPersonelBolumBilgisi : EntityBusBase<PersonelBolumBilgisi>, IBusPersonelBolumBilgisi
    {
        public BusPersonelBolumBilgisi(IDalPersonelBolumBilgisi entityDalBase) : base(entityDalBase)
        {
        }
    }
}
