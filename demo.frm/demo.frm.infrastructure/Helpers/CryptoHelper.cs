using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.infrastructure.Helpers
{
    public class CryptoHelper
    {
        public static byte[] CriptografarSenha(string senha)
        {
            return Criptografar(senha, "eckhart-ledger-darknight-3698");
        }

        public static byte[] Criptografar(string texto, string salt)
        {
            while (salt.Length < 6)
            {
                salt += salt + "Z";
            }
            using (var sha = SHA512.Create())
            {
                salt = Encoding.UTF8.GetString(sha.ComputeHash(Encoding.UTF8.GetBytes(salt.Substring(salt.Length - 4))));
                return sha.ComputeHash(Encoding.UTF8.GetBytes(texto + salt));
            }
        }
    }
}
