using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiViewModel.ViewModel;

namespace MultiViewModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MultiValidation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Prefix = "login")]LoginViewModel Login)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("MultiValidation", Login);
            }

            return Content(Login.Email + ", " + Login.Password);
        }

        [HttpPost]
        public ActionResult Register([Bind(Prefix = "register")]RegisterViewModel Register)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("MultiValidation", Register);
            }

            return Content(Register.Email + ", " + Register.Password + ", " + Register.Account);
        }
    }
}