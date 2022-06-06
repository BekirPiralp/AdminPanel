using AdminPanel.EntityLayer.Concrete.Other.ArabaKismi;
using AdminPanel.EntityLayer.Concrete.Other.IletisimKismi;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.ArabaKismi;
using AdminPanle.BusinessLayer.Abstract.Other.IletisimKismi;
using AdminPanle.BusinessLayer.Other;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.WebAPI.Controllers.Test
{
    //[Route("test1")]
    public class Test1Controller : BaseController<IBusIletisim, Iletisim>
    {

        public Test1Controller() : base(BusOlusturucu.Olustur().Iletisim)
        {
        }

        [HttpPut()]
        [Route("[controller]/putt")]
        public ActionResult put()
        {
            return Ok("[controller] başarılı get all");
        }
    }
}
