using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.frm.domain;
using demo.frm.domain.Entities;
using demo.frm.domain.Repositories;

namespace demo.frm.infrastructure.data.Repositories
{
    public class PaisRepository : Repository<PaisView>, IPaisRepository
    {
        public PaisRepository(IQueryableUnitOfWork unitOfWork)
            : base(unitOfWork) { }
    }
}
