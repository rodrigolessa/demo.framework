using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.infrastructure
{
    public static class Constants
    {
        #region Geral

        public static class Geral
        {
            public static class Acao
            {
                public const string Alterar = "Alterar";
                public const string Excluir = "Excluir";
                public const string Incluir = "Incluir";
                public const string Consultar = "Consultar";
                public const string EnviarEmail = "Enviar E-mail";
            }

            public static class Sistema
            {
                public const string Principal = "Teste";

                public static class SubSistema
                {
                    public const string Primeiro = "Teste";

                    public static class Modulo
                    {
                        public const string Primeiro = "Teste";
                    }
                }
            }
        }

        #endregion

        #region Configuração

        public static class ArquivoDeConfiguracao
        {
            public static string BaseDir = System.AppDomain.CurrentDomain.BaseDirectory;
            public static string CsvDir = BaseDir + @"\csv\";
            public static string LogDir = BaseDir + @"\log\";

            public static string ArquivoLogErro = "log_de_erro_em_" + System.DateTime.Now.ToString("yyyy_MM_dd") + ".txt";
        }

        #endregion
    }
}
