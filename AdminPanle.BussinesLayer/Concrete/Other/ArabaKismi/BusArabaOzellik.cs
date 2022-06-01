using AdminPanel.DataAccessLayer.Abstract.Other.Genel.ArabaKismi;
using AdminPanel.EntityLayer.Concrete.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.ArabaKismi
{
    public class BusArabaOzellik : EntityBusBase<ArabaOzellik>, IBusArabaOzellik
    {
        public BusArabaOzellik(IDalArabaOzellik entityDalBase) : base(entityDalBase)
        {
        }
    }
}
