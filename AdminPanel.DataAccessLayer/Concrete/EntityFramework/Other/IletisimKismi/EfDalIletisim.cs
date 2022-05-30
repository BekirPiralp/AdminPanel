using AdminPanel.DataAccessLayer.Abstract.Other.Genel.IletisimKsimi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.IletisimKismi;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.IletisimKismi
{
    public class EfDalIletisim : EntityEfDal<Iletisim, EfContext>, IDalIletisim
    {
    }
}
