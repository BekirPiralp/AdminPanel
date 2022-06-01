using AdminPanel.DataAccessLayer.Abstract.Other.Genel.MusteriKismi;
using AdminPanel.EntityLayer.Concrete.Other.MusteriKismi;
using AdminPanle.BusinessLayer.Abstract.Other.MusteriKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.MusteriKismi
{
    public class BusMusteri : EntityBusBase<Musteri>, IBusMusteri
    {
        public BusMusteri(IDalMusteri entityDalBase) : base(entityDalBase)
        {
        }
    }
}
