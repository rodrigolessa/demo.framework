using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using demo.frm.infrastructure;

namespace demo.frm.domain
{
    public interface IReadOnlyRepository<TEntity> : IDisposable
        where TEntity : EntityBase
    {
        IUnitOfWork UnitOfWork { get; }

        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter);
    }
}
