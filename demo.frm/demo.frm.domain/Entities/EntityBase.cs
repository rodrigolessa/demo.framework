using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> DataDeInclusao { get; set; }
    }
}
