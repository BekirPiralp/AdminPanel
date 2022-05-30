using AdminPanel.DataAccessLayer.Abstract.Other.Genel.HakkindaKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.HakkindaKismi;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.HakkindaKismi
{
    public class EfDalHakkindaIcerik : EntityEfDal<HakkindaIcerik, EfContext>, IDalHakkindaIcerik
    {
    }
}
