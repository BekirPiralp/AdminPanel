using AdminPanel.DataAccessLayer.Abstract.Other.Genel.PaketKismi;
using AdminPanel.EntityLayer.Concrete.Other.PaketKismi;
using AdminPanle.BusinessLayer.Abstract.Other.PaketKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.PaketKismi
{
    public class BusPaketAitOzellik : EntityBusBase<PaketAitOzellik>, IBusPaketAitOzellik
    {
        public BusPaketAitOzellik(IDalPaketAitOzellik entityDalBase) : base(entityDalBase)
        {
        }
    }
}
