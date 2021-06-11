using KullaniciGirisSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KullaniciGirisSistemi.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                List<UserViewModel> users = HttpContext.Session.Get<List<UserViewModel>>("users");

                UserViewModel currentUser= users.FirstOrDefault(u => u.Name == model.Name.Trim() && u.Password == model.Password.Trim());

                if (currentUser != null)
                {
                    HttpContext.Session.Set<UserViewModel>("currentUser", currentUser);
                }
                else
                {
                    ViewBag.NotFound = "Kullanıcı adı veya şifre yanlış";
                    return View();
                }
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("currentUser");
         
            return RedirectToAction("Login");
        }
    }
}
