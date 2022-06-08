using AdminPanel.EntityLayer.Concrete.Other.PersonelKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.PersonelKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.PersonelKismi
{
    public class PersonelSifreController : BaseController<IBusPersonelSifre, PersonelSifre>
    {
        public PersonelSifreController() : base(BusOlusturucu.Olustur().PersonelSifre)
        {
        }

    }
}
