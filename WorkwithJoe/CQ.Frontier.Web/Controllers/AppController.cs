using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CQ.Frontier.Web.Controllers
{
    public class AppController : Controller
    {
        //
        // GET: /App/
        [Authorize]//authorizes only certain roles to access it
        public ActionResult Index()
        {
            return View();
        }

    }
}
