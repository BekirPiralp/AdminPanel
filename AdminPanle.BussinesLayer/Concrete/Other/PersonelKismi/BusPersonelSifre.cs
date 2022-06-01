using AdminPanel.DataAccessLayer.Abstract.Other.Genel.PersonelKismi;
using AdminPanel.EntityLayer.Concrete.Other.PersonelKismi;
using AdminPanle.BusinessLayer.Abstract.Other.PersonelKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.PersonelKismi
{
    public class BusPersonelSifre : EntityBusBase<PersonelSifre>, IBusPersonelSifre
    {
        public BusPersonelSifre(IDalPersonelSifre entityDalBase) : base(entityDalBase)
        {
        }
    }
}
