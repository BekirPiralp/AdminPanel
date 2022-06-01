using AdminPanel.DataAccessLayer.Abstract.Other.Genel.FirmaKismi;
using AdminPanel.EntityLayer.Concrete.Other.FirmaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.FirmaKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.FirmaKismi
{
    public class BusFirma : EntityBusBase<Firma>, IBusFirma
    {
        public BusFirma(IDalFirma entityDalBase) : base(entityDalBase)
        {
        }
    }
}
