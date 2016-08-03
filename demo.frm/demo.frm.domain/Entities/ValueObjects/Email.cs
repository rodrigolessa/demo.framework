using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using demo.frm.infrastructure.Helpers;

namespace demo.frm.domain.Entities.ValueObjects
{
    public class Email
    {
        public const int EnderecoMaxLength = 100;
        public string Endereco { get; private set; }

        protected Email() { }

        public static bool IsValid(string email)
        {
            var regexEmail = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            return regexEmail.IsMatch(email);
        }

        public Email(string endereco)
        {
            ValidationHelper.StringLength("E-mail", endereco, EnderecoMaxLength);

            if (IsValid(endereco) == false)
                throw new Exception("E-mail inválido");

            Endereco = endereco;
        }
    }
}
