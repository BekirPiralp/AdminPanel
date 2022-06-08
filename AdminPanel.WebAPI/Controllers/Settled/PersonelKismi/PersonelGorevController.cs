using AdminPanel.EntityLayer.Concrete.Other.PersonelKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.PersonelKismi;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.PersonelKismi
{
    public class PersonelGorevController : BaseController<IBusPersonelGorev, PersonelGorev>
    {
        public PersonelGorevController() : base(BusOlusturucu.Olustur().PersonelGorev)
        {
        }
    }
}
