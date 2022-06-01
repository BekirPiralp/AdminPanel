using AdminPanel.DataAccessLayer.Abstract.Other.Genel.PersonelKismi;
using AdminPanel.EntityLayer.Concrete.Other.PersonelKismi;
using AdminPanle.BusinessLayer.Abstract.Other.PersonelKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.PersonelKismi
{
    public class BusPersonel : EntityBusBase<Personel>, IBusPersonel
    {
        public BusPersonel(IDalPersonel entityDalBase) : base(entityDalBase)
        {
        }
    }
}
