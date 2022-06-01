using AdminPanel.DataAccessLayer.Abstract.Other.Genel.PaketKismi;
using AdminPanel.EntityLayer.Concrete.Other.PaketKismi;
using AdminPanle.BusinessLayer.Abstract.Other.PaketKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.PaketKismi
{
    internal class BusPaketOzellik : EntityBusBase<PaketOzellik>, IBusPaketOzellik
    {
        public BusPaketOzellik(IDalPaketOzellik entityDalBase) : base(entityDalBase)
        {
        }
    }
}
