using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdminPanel.EntityLayer.Concrete.Other.TestPostgre;
using AdminPanel.WebAPI.Controllers.Base.Tests;
using AdminPanle.BusinessLayer.Abstract.Other.TestProduct;
using AdminPanel.EntityLayer.Concrete.Other.Product;

namespace AdminPanel.WebAPI.Controllers.Settled.TestProduct.Tests
{
    [TestClass()]
    public class ProductControllerTests: BaseControllerTests<ProductController, IBusProduct, Product>
    {

        [TestInitialize]
        public void ClassKurulum()
        {
            this.Kur();
        }
    }
}