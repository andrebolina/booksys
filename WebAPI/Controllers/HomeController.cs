using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        /*
         * #Documentação
         * Rota default (Home > Index) retorna a informação que não há rotas nos valores padrões
         */
        public ActionResult Index()
        {
            return Content("<xml><message>Não foram encontradas rotas para estes valores</message></xml>", "text/xml");
        }
    }
}
