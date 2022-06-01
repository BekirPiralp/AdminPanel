using AdminPanel.DataAccessLayer.Abstract.Other.Genel.PaketKismi;
using AdminPanel.EntityLayer.Concrete.Other.PaketKismi;
using AdminPanle.BusinessLayer.Abstract.Other.PaketKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.PaketKismi
{
    public class BusPaket : EntityBusBase<Paket>, IBusPaket
    {
        public BusPaket(IDalPaket entityDalBase) : base(entityDalBase)
        {
        }
    }
}
