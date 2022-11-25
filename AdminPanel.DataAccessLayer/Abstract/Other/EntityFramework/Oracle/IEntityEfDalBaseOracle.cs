using AdminPanel.DataAccessLayer.Abstract.Base;
using AdminPanel.EntityLayer.Abctract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DataAccessLayer.Abstract.Other.EntityFramework.Oracle
{
    public interface IEntityEfDalBaseOracle<TEntity> : IEntityEfDalBase<TEntity>
        where TEntity : class, IEntity, new()
    {
    }
}
