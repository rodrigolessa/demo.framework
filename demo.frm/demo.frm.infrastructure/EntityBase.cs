using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.infrastructure
{
    public abstract partial class EntityBase
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> DataDeInclusao { get; set; }
    }

    //public abstract class EntityBase<T> : IValidatable<T>
    //{
    //    public abstract bool Validate(out IEnumerable<string> brokenRules);

    //    public bool Validate(IValidator<T> validator, out IEnumerable<string> brokenRules)
    //    {
    //        brokenRules = validator.BrokenRules();
    //        return validator.IsValid();
    //    }

    //    public bool Validate(IEnumerable<IValidator<T>> validator, out IEnumerable<string> brokenRules)
    //    {
    //        var result = new List<string>();
    //        var isValid = true;

    //        foreach (var item in validator)
    //        {
    //            result.AddRange(item.BrokenRules());

    //            if (!item.IsValid())
    //                isValid = false;
    //        }

    //        brokenRules = result.AsEnumerable();

    //        return isValid;
    //    }
    //}
}
