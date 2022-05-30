using AdminPanel.DataAccessLayer.Abstract.Other.Genel.FirmaKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.FirmaKismi;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.FirmaKismi
{
    public class EfDalFirma : EntityEfDal<Firma, EfContext>, IDalFirma
    {
    }
}
