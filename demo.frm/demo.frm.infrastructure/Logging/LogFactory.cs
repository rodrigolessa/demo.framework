using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.infrastructure.Logging
{
    public class LogFactory
    {
        static ILogFactory _current = null;

        public static void SetCurrent(ILogFactory logFactory)
        {
            _current = logFactory;
        }

        public static ILogService CreateLog()
        {
            return (_current != null ? _current.Create() : null);
        }
    }
}
