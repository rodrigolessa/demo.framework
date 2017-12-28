using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.infrastructure.Validator
{
    public class DataAnnotationsEntityValidatorFactory : IEntityValidatorFactory
    {
        public IEntityValidator Create()
        {
            return new DataAnnotationsEntityValidator();
        }
    }
}
