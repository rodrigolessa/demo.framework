using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.infrastructure.Logging
{
    public interface ILogFactory
    {
        int? IdDoUsuarioLogado { get; set; }
        ILogService Create();
    }
}
