using AdminPanel.EntityLayer.Abctract;

namespace AdminPanel.DataAccessLayer.Abstract.Other.EntityFramework.Oracle
{
    public interface IEntityEfDalBaseOracle<TEntity> : IEntityEfDalBase<TEntity>
        where TEntity : class, IEntity, new()
    {
        
    }
}
