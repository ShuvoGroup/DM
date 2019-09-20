using DM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DM.Controllers
{
    public class AccountController : Controller
    {
        DMDATAEntities context = new DMDATAEntities();
        //GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User model)
        {
            bool isValid = context.Users.Any(x=>x.Name==model.Name && x.Password==model.Password);
            if (isValid)
            {


               
                //Any Logic
                //return View("Index", "_WebmasterLayout", model);



                FormsAuthentication.SetAuthCookie(model.Name,false);
                return RedirectToAction("Index", "Home");
                
            }

            ModelState.AddModelError("", "Invalid User Name and Password");
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
    
      [HttpPost]
        public ActionResult SignUp(User model)
        {         
                context.Users.Add(model);
                context.SaveChanges();
          
                return RedirectToAction("Login");
        }
        public ActionResult LogOut()
        {
            /*HttpContext.Session.Remove(SessionKeys.UserType);*///This will remove all keys from session variable. For example, if your session contains id, name, phone number, email etc.
            HttpContext.Session.RemoveAll();//This will remove all session from application
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
    }

}