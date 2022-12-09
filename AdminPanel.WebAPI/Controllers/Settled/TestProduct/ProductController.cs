using AdminPanel.EntityLayer.Concrete.Other.Product;
using AdminPanel.WebAPI.Controllers.Base;
using AdminPanle.BusinessLayer.Abstract.Other.TestProduct;
using AdminPanle.BusinessLayer.Other;

namespace AdminPanel.WebAPI.Controllers.Settled.TestProduct
{
    public class ProductController : BaseController<IBusProduct,Product>
    {
        public ProductController():base(BusOlusturucu.Olustur().Product)
        {

        }
    }
}
