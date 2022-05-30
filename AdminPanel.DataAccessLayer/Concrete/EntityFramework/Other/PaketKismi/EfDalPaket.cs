using AdminPanel.DataAccessLayer.Abstract.Other.Genel.PaketKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.PaketKismi;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.PaketKismi
{
    public class EfDalPaket : EntityEfDal<Paket, EfContext>, IDalPaket
    {
    }
}
