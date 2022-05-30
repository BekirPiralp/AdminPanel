using AdminPanel.DataAccessLayer.Abstract.Other.Genel.ReferansKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.ReferansKismi;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.ReferansKismi
{
    public class EfDalReferans : EntityEfDal<Referans, EfContext>, IDalReferans
    {
    }
}
