using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        [HttpGet]
        public ActionResult Login()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Login(Users users)
        {
            TempData["Wrong"] = "Wrong Credentials";
            //Users users = new Users(); 
            if(users.UserName=="admin" && users.Password=="admin")
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
               
            }
            return View();
        }
    }
}