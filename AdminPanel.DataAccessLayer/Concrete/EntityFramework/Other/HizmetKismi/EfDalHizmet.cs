using AdminPanel.DataAccessLayer.Abstract.Other.Genel.HizmetKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.HizmetKismi;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.HizmetKismi
{
    public class EfDalHizmet : EntityEfDal<Hizmet, EfContext>, IDalHizmet
    {
    }
}
