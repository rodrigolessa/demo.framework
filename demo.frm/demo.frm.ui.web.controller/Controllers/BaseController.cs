using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.frm.infrastructure.Security;

namespace demo.frm.ui.web.controller.Controllers
{
    public class BaseController //: System.Web.Mvc.Controller
    {
        protected IApplicationContext ApplicationContext;

        public BaseController(IApplicationContext applicationContext)
        {
            ApplicationContext = applicationContext;
        }

        public BaseController()
        {

        }
    }
}
