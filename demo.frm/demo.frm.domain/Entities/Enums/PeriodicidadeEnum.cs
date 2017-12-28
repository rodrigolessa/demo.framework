using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.domain.Entities.Enums
{
    public enum PeriodicidadeEnum
    {
        [Description("Mensal")]
        Mensal = 'M',
        [Description("Trimestral")]
        Trimestral = 'T',
        [Description("Anual")]
        Anual = 'A',
        [Description("Bienal")]
        Bienal = 'B'
    }
}
