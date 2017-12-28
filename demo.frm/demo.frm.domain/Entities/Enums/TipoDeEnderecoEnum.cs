using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.domain.Entities.Enums
{
    public enum TipoDeEnderecoEnum
    {
        [Description("Principal")]
        Principal = 'P',
        [Description("Cobrança")]
        Cobranca = 'C',
        [Description("Outros")]
        Outros = 'O'
    }
}
