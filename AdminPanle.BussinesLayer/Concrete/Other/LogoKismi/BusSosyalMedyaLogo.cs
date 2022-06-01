using AdminPanel.DataAccessLayer.Abstract.Other.Genel.LogoKismi;
using AdminPanel.EntityLayer.Concrete.Other.LogoKismi;
using AdminPanle.BusinessLayer.Abstract.Other.LogoKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.LogoKismi
{
    public class BusSosyalMedyaLogo : EntityBusBase<SosyalMedyaLogo>, IBusSosyalMedyaLogo
    {
        public BusSosyalMedyaLogo(IDalSosyalMedyaLogo entityDalBase) : base(entityDalBase)
        {
        }
    }
}
