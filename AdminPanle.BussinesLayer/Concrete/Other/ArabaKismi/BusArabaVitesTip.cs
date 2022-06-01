using AdminPanel.DataAccessLayer.Abstract.Other.Genel.ArabaKismi;
using AdminPanel.EntityLayer.Concrete.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.ArabaKismi
{
    public class BusArabaVitesTip : EntityBusBase<ArabaVitesTip>, IBusArabaVitesTip
    {
        public BusArabaVitesTip(IDalArabaVitesTip entityDalBase) : base(entityDalBase)
        {
        }
    }
}
