using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.domain.Entities.Enums
{
    public enum TipoDePessoaEnum
    {
        [Description("Pessoa Física")]
        PessoaFisica = 'F',
        [Description("Pessoa Jurídica")]
        PessoaJuridica = 'J'
    }
}
