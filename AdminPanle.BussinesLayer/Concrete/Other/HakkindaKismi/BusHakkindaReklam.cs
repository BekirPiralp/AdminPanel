using AdminPanel.DataAccessLayer.Abstract.Other.Genel.HakkindaKismi;
using AdminPanel.EntityLayer.Concrete.Other.HakkindaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.HakkindaKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.HakkindaKismi
{
    public class BusHakkindaReklam : EntityBusBase<HakkindaReklam>, IBusHakkindaReklam
    {
        public BusHakkindaReklam(IDalHakkindaReklam entityDalBase) : base(entityDalBase)
        {
        }
    }
}
