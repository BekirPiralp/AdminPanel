using AdminPanel.DataAccessLayer.Abstract.Other.Genel.HakkindaKismi;
using AdminPanel.EntityLayer.Concrete.Other.HakkindaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.HakkindaKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.HakkindaKismi
{
    public class BusHakkindaIcerik : EntityBusBase<HakkindaIcerik>, IBusHakkindaIcerik
    {
        public BusHakkindaIcerik(IDalHakkindaIcerik entityDalBase) : base(entityDalBase)
        {
        }
    }
}
