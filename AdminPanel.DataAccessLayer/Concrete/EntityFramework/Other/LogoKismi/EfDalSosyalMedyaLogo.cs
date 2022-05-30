using AdminPanel.DataAccessLayer.Abstract.Other.Genel.LogoKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.LogoKismi;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.LogoKismi
{
    public class EfDalSosyalMedyaLogo : EntityEfDal<SosyalMedyaLogo, EfContext>, IDalSosyalMedyaLogo
    {
    }
}
