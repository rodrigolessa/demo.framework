using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.infrastructure.Logging
{
    public class Log
    {
        public long Id { get; set; }
        public Nullable<int> IdDoUsuario { get; set; }
        public string Modulo { get; set; }
        public string Acao { get; set; }
        public string Descricao { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
    }
}
