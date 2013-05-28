using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CQ.Frontier.Web.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logout()
        {
            return View();
        }



    }
}
