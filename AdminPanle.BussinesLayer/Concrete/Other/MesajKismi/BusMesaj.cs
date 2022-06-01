using AdminPanel.DataAccessLayer.Abstract.Other.Genel.MesajKismi;
using AdminPanel.EntityLayer.Concrete.Other.MesajKismi;
using AdminPanle.BusinessLayer.Abstract.Other.MesajKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.MesajKismi
{
    public class BusMesaj : EntityBusBase<Mesaj>, IBusMesaj
    {
        public BusMesaj(IDalMesaj entityDalBase) : base(entityDalBase)
        {
        }
    }
}
