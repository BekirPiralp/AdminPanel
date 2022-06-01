using AdminPanel.DataAccessLayer.Abstract.Other.Genel.FirmaKismi;
using AdminPanel.EntityLayer.Concrete.Other.FirmaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.FirmaKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.FirmaKismi
{
    public class BusBayiYonetici : EntityBusBase<BayiYonetici>, IBusBayiYonetici
    {
        public BusBayiYonetici(IDalBayiYonetici entityDalBase) : base(entityDalBase)
        {
        }
    }
}
