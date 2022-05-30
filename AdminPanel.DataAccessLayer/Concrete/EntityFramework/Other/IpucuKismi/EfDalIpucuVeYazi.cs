using AdminPanel.DataAccessLayer.Abstract.Other.Genel.IpucuKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.IpucuKismi;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.IpucuKismi
{
    public class EfDalIpucuVeYazi : EntityEfDal<IpucuVeYazi, EfContext>, IDalIpucuVeYazi
    {
    }
}
