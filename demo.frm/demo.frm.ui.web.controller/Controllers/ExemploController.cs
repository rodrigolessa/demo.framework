using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using demo.frm.domain.Entities;
using demo.frm.domain.Repositories;
using demo.frm.infrastructure.Security;
using demo.frm.ui.web.controller.ViewModel;

namespace demo.frm.ui.web.controller.Controllers
{
    public class ExemploController : BaseController
    {
        private IExemploRepository _repository;
        private IExemploRepository Repository
        {
            get
            {
                return _repository;
            }
        }

        public ExemploController(IExemploRepository repository, IApplicationContext applicationContext)
            : base(applicationContext)
        {
            _repository = Repository;
        }

        /*

        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }

        public ActionResult Index()
        {
            var login = new ExemploViewModel();

            return View(login);
        }

        [HttpPost]
        public JsonResult Salvar(ExemploViewModel viewModel)
        {
            viewModel.DoSuccess("Acesso permitido", "Acesso!");

            Exemplo exemplo = viewModel.Traduzir<Exemplo>();
            exemplo.GenerateNewIdentity();

            var erros = exemplo.DoIfIsValid<Exemplo>(() =>
            {
                UsuarioRepository.Add(usuario);
                UsuarioRepository.UnitOfWork.Commit();
            });

            if (erros.HasErros())
                return Json(erros.GetViewModel());

            return Json(viewModel);
        }

        */
    }
}