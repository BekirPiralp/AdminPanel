using AdminPanel.EntityLayer.Abctract;

namespace AdminPanel.DataAccessLayer.Abstract.Other.EntityFramework.MsSql
{
    public interface IEntityEfDalBaseMsSql<TEntity>:IEntityEfDalBase<TEntity>
        where TEntity : class,IEntity,new()
    {
    }
}
