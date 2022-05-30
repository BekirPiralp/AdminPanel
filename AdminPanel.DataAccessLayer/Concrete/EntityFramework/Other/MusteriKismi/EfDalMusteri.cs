using AdminPanel.DataAccessLayer.Abstract.Other.Genel.MusteriKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.MusteriKismi;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.MusteriKismi
{
    public class EfDalMusteri : EntityEfDal<Musteri, EfContext>, IDalMusteri
    {
    }
}
