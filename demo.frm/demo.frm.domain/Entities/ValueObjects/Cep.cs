using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.frm.infrastructure.Helpers;

namespace demo.frm.domain.Entities.ValueObjects
{
    public class Cep
    {
        public Int64? CepCod { get; private set; }
        public const int CepMaxLength = 8;

        protected Cep() { }

        public Cep(string cep)
        {
            ValidationHelper.ForNullOrEmptyDefaultMessage("CEP", cep);
            cep = TextHelper.GetNumeros(cep);
            ValidationHelper.StringLength("CEP", CepMaxLength, cep);
            try
            {
                CepCod = Convert.ToInt64(cep);
            }
            catch (Exception)
            {
                throw new Exception("Cep inválido: " + cep);
            }
        }

        public bool Vazio()
        {
            return !CepCod.HasValue;
        }

        public string GetCepFormatado()
        {
            if (CepCod == null)
                return "";

            var cep = CepCod.ToString();

            while (cep.Length < 8)
                cep = "0" + cep;

            return cep.Substring(0, 5) + "-" + cep.Substring(5);
        }
    }
}
