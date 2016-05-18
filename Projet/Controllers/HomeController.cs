using Projet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController2
        public ActionResult Index()
        {
            var context = new DatabaseEntities();
            var users = context.User.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult insertUser()
        {
            var nom = Request.Form["nom"];
            var mdp = Request.Form["mdp"];
            var mail = Request.Form["email"];
            User user = new User();

            user.Name = nom;
            user.Password = mdp;
            user.Email = mail;

            var context = new DatabaseEntities();
            context.User.Add(user);
            context.SaveChanges();

            return View("Index");
        }

    }
}