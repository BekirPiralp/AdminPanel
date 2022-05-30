using AdminPanel.DataAccessLayer.Abstract.Other.Genel.PersonelKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.PersonelKismi;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.PersonelKismi
{
    public class EfDalPersonelSosyalMedya : EntityEfDal<PersonelSosyalMedya, EfContext>, IDalPersonelSosyalMedya
    {
    }
}
