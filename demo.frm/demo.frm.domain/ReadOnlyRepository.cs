using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.frm.infrastructure;

namespace demo.frm.domain
{
    public class ReadOnlyRepository<TEntity> : IReadOnlyRepository<TEntity>
        where TEntity : EntityBase
    {
        #region Members

        IQueryableUnitOfWork _UnitOfWork;

        #endregion

        #region Construtor

        public ReadOnlyRepository(IQueryableUnitOfWork unitOfWork)
        {
            if (unitOfWork == (IUnitOfWork)null)
                throw new ArgumentNullException("unitOfWork");

            _UnitOfWork = unitOfWork;
        }

        #endregion

        #region IReadOnlyRepository Members

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _UnitOfWork;
            }
        }

        public TEntity Get(int id)
        {
            if (id != 0)
                return GetSet().Find(id);
            else
                return null;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return GetSet();
        }

        public IEnumerable<TEntity> GetFiltered(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return GetSet().Where(filter);
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (_UnitOfWork != null)
                _UnitOfWork.Dispose();
        }

        #endregion

        #region Métodos Privados

        IDbSet<TEntity> dbset = null;
        IDbSet<TEntity> GetSet()
        {
            if (dbset == null)
                dbset = _UnitOfWork.CreateSet<TEntity>();

            return dbset;
        }

        #endregion
    }
}
