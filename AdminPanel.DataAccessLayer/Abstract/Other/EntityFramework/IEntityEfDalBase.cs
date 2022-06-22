using AdminPanel.DataAccessLayer.Abstract.Base;
using AdminPanel.EntityLayer.Abctract;

namespace AdminPanel.DataAccessLayer.Abstract.Other.EntityFramework
{
    public interface IEntityEfDalBase<TEntity> : IEntityDalBase<TEntity>
        where TEntity : class, IEntity, new()
    {

    }
}
