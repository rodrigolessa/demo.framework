using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.ui.web.controller.ViewModel
{
    public class ExemploViewModel : ViewModelBase
    {
        public ExemploViewModel() : base() { }
        public Guid Id
        {
            get;
            set;
        }

        public string Login
        {
            get;
            set;
        }

        public string Nome
        {
            get;
            set;
        }


        public string Senha
        {
            get;
            set;
        }

        public string ConfirmaSenha
        {
            get;
            set;
        }

        internal static ExemploViewModel Empty()
        {
            return new ExemploViewModel()
            {
            };
        }
    }
}
