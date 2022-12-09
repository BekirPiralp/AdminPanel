using AdminPanel.DataAccessLayer.Abstract.Other.EntityFramework.MsSql;
using AdminPanel.EntityLayer.Abctract;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base.MsSql
{
    public class EntityEfDalMsSql<TEntity, TContext> : EntityEfDal<TEntity, TContext>, IEntityEfDalBaseMsSql<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
    }
}
