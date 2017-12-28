using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.domain.Entities.Enums
{
    public enum SituacaoModuloEnum
    {
        [Description("Liberado")]
        Liberado = 'L',
        [Description("Teste")]
        Teste = 'T',
        [Description("Bloqueado")]
        Bloqueado = 'B'
    }
}
