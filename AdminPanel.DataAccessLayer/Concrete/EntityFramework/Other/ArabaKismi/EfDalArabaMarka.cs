using AdminPanel.DataAccessLayer.Abstract.Other.Genel.ArabaKismi;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base;
using AdminPanel.EntityLayer.Concrete.Other.ArabaKismi;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.ArabaKismi
{
    public class EfDalArabaMarka : EntityEfDal<ArabaMarka, EfContext>, IDalArabaMarka
    {
    }
}
