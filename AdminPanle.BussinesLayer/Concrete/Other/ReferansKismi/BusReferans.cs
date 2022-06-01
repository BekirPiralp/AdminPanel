using AdminPanel.DataAccessLayer.Abstract.Other.Genel.ReferansKismi;
using AdminPanel.EntityLayer.Concrete.Other.ReferansKismi;
using AdminPanle.BusinessLayer.Abstract.Other.ReferansKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.ReferansKismi
{
    public class BusReferans : EntityBusBase<Referans>, IBusReferans
    {
        public BusReferans(IDalReferans entityDalBase) : base(entityDalBase)
        {
        }
    }
}
