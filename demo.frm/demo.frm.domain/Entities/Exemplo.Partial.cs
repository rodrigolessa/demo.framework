using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.frm.domain.Entities.ValueObjects;
using demo.frm.infrastructure;
using System.ComponentModel.DataAnnotations;

namespace demo.frm.domain.Entities
{
    public partial class Exemplo : EntityBase, IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.Login))
                validationResults.Add(new ValidationResult(string.Format(Messages.ValidationGenericoCampoObrigatorio, "Login")));

            return validationResults;

        }
    }
}