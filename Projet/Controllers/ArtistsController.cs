using Projet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet.Controllers
{
    public class ArtistsController : Controller
    {
        // GET: Artists
        public ActionResult Index(int id)
        {
            var context = new DatabaseEntities();
            List<Albums> albums = context.Albums.Where(m => m.IdArtist == id).ToList();

            context = new DatabaseEntities();
            ViewBag.NameArtist = context.Artists.Where(m => m.Id == id).First().Name;

            return View(albums);
        }
    }
}