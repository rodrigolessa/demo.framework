using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.frm.infrastructure;

namespace demo.frm.domain.Entities
{
    public partial class PaisView : EntityBase
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }
    }
}
