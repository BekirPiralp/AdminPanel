using AdminPanel.DataAccessLayer.Abstract.Other.Genel.MesajKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.MesajKismi;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.MesajKismi
{
    public class EfDalMesaj : EntityEfDal<Mesaj, EfContext>, IDalMesaj
    {
    }
}
