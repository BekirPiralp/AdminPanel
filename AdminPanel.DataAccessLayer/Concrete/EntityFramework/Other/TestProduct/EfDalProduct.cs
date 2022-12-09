using AdminPanel.DataAccessLayer.Abstract.Other.Genel.TestProduct;
using AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base.MsSql;
using AdminPanel.EntityLayer.Concrete.Other.Product;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Other.TestProduct
{
    public class EfDalProduct<TContext>:EntityEfDalMsSql<Product,TContext>,IDalProduct
        where TContext: DbContext,new()
    {
    }
}
