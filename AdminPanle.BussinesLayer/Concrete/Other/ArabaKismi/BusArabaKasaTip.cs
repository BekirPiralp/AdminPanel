using AdminPanel.DataAccessLayer.Abstract.Base;
using AdminPanel.DataAccessLayer.Abstract.Other.Genel.ArabaKismi;
using AdminPanel.EntityLayer.Concrete.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.ArabaKismi
{
    public class BusArabaKasaTip : EntityBusBase<ArabaKasaTip>, IBusArabaKasaTip
    {
        public BusArabaKasaTip(IDalArabaKasaTip entityDalBase) : base(entityDalBase)
        {
        }
    }
}
