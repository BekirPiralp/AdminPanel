using AdminPanel.DataAccessLayer.Abstract.Other.Genel.PersonelKismi;
using AdminPanel.EntityLayer.Concrete.Other.PersonelKismi;
using AdminPanle.BusinessLayer.Abstract.Other.PersonelKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.PersonelKismi
{
    public class BusPersonelSosyalMedya : EntityBusBase<PersonelSosyalMedya>, IBusPersonelSosyalMedya
    {
        public BusPersonelSosyalMedya(IDalPersonelSosyalMedya entityDalBase) : base(entityDalBase)
        {
        }
    }
}
