using AdminPanel.DataAccessLayer.Abstract.Other.Genel.FirmaKismi;
using AdminPanel.EntityLayer.Concrete.Other.FirmaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.FirmaKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.FirmaKismi
{
    public class BusBayi : EntityBusBase<Bayi>, IBusBayi
    {
        public BusBayi(IDalBayi entityDalBase) : base(entityDalBase)
        {
        }
    }
}
