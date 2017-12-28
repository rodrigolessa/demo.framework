using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.infrastructure.Validator
{
    public interface IValidator<in T>
    {
        bool IsValid();
        IEnumerable<string> BrokenRules();
    }
}
