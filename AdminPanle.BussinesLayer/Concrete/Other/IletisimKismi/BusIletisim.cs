using AdminPanel.DataAccessLayer.Abstract.Other.Genel.IletisimKsimi;
using AdminPanel.EntityLayer.Concrete.Other.IletisimKismi;
using AdminPanle.BusinessLayer.Abstract.Other.IletisimKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.IletisimKismi
{
    public class BusIletisim : EntityBusBase<Iletisim>, IBusIletisim
    {
        public BusIletisim(IDalIletisim entityDalBase) : base(entityDalBase)
        {
        }
    }
}
