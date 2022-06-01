using AdminPanel.DataAccessLayer.Abstract.Other.Genel.HizmetKismi;
using AdminPanel.EntityLayer.Concrete.Other.HizmetKismi;
using AdminPanle.BusinessLayer.Abstract.Other.HizmetKismi;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.HizmetKismi
{
    public class BusHizmetAltOzellik : EntityBusBase<HizmetAltOzellik>, IBusHizmetAltOzellik
    {
        public BusHizmetAltOzellik(IDalHizmetAltOzellik entityDalBase) : base(entityDalBase)
        {
        }
    }
}
