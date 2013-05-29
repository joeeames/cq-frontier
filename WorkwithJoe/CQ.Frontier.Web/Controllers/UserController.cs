using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Models.UserModel user)
        {
            if (ModelState.IsValid)
            {
                Repo.UserRepo userRepo = new Repo.UserRepo();

                userRepo.CreateUser(user.username,user.passwordhash);

                return RedirectToAction("Login", "User");
            }
            return View(user);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.UserModel user)
        {
            if (ModelState.IsValid)
            {
                if (isValid(user.username, user.passwordhash))
                {
                    FormsAuthentication.SetAuthCookie(user.username, false);
                    return RedirectToAction ("Index","App");
                }
                else
                {
                    ModelState.AddModelError("","Login data is incorrect");
                }
            }
            return View(user);
        }
       
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","AppController");
        }

        private bool isValid(string username,string password)
        {
            bool isValid = false;
            Repo.UserRepo userRepo = new Repo.UserRepo();
            var user = userRepo.GetUsers().FirstOrDefault(u => u.username == username && u.passwordhash == password);
            if (user != null)
            {
                isValid = true;
            }
            return isValid;
        }

    }
}
