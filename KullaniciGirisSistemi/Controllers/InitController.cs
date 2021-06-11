using KullaniciGirisSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KullaniciGirisSistemi.Controllers
{
    public class InitController : Controller
    {
        public IActionResult Index()
        {
            List<UserViewModel> users = new List<UserViewModel>();

            for (int i = 0; i < 5; i++)
            {
                users.Add(new UserViewModel() { Name = $"user{i}", Password = $"{i}" });
            }

            HttpContext.Session.Set<List<UserViewModel>>("users", users);

            return RedirectToAction("Index","Home");
        }
    }
}
