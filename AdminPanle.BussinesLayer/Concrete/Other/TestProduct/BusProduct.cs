using AdminPanel.DataAccessLayer.Abstract.Other.Genel.TestProduct;
using AdminPanel.EntityLayer.Concrete.Other.Product;
using AdminPanle.BusinessLayer.Abstract.Other.TestProduct;
using AdminPanle.BusinessLayer.Concrete.Base;

namespace AdminPanle.BusinessLayer.Concrete.Other.TestProduct
{
    public class BusProduct:EntityBusBase<Product,IDalProduct>,IBusProduct
    {
        public BusProduct(IDalProduct entityDalBase):base(entityDalBase)
        {

        }
    }
}
