using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.infrastructure.Validator
{
    public abstract class ValidatorBase<T> : IValidator<T>
    {
        protected readonly T Entity;

        protected ValidatorBase(T entity)
        {
            Entity = entity;
        }

        public bool IsValid()
        {
            return !BrokenRules().Any();
        }

        public abstract IEnumerable<string> BrokenRules();
    }
}
