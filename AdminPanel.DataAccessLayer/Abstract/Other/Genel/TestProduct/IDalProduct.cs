using AdminPanel.DataAccessLayer.Abstract.Other.EntityFramework.MsSql;
using pro = AdminPanel.EntityLayer.Concrete.Other.Product;

namespace AdminPanel.DataAccessLayer.Abstract.Other.Genel.TestProduct
{
    public interface IDalProduct:IEntityEfDalBaseMsSql<pro.Product>
    {
    }
}
