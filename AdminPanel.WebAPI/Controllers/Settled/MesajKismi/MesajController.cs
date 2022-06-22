using AdminPanel.EntityLayer.Concrete.Other.MesajKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.MesajKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.MesajKismi
{
    public class MesajController : BaseController<IBusMesaj, Mesaj>
    {
        public MesajController() : base(BusOlusturucu.Olustur().Mesaj)
        {
        }

    }
}
