using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.infrastructure.Validator
{
    public interface IValidatable<T>
    {
        bool Validate(out IEnumerable<string> brokenRules);
        bool Validate(IValidator<T> validator, out IEnumerable<string> brokenRules);
    }
}
