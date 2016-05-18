using Projet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet.Controllers
{
    public class AlbumsController : Controller
    {
        // GET: Albums
        public ActionResult Index()
        {
            var context = new DatabaseEntities();
            var albums = context.Albums.ToList().OrderBy(m=>m.IdArtist);
            return View(albums);
        }

        [HttpGet]
        public ActionResult Infos(int id)
        {
            var context = new DatabaseEntities();
            var comments = context.Comments.Where(m => m.IdAlbum == id).ToList();

            context = new DatabaseEntities();
            var album = context.Albums.Find(id);

            context = new DatabaseEntities();
            var artist = context.Artists.Where(m => m.Id == album.IdArtist).First();

            context = new DatabaseEntities();
            vmTracksComments vm = new vmTracksComments();
            if (context.Comments.Where(m => m.IdAlbum == id).First().Value == null)
            {
                vm.Comments = null;
                vm.Tracks = context.Tracks.Where(m => m.IdAlbum == id).ToList();
            }
            else
            {
                vm.Comments = context.Comments.Where(m => m.IdAlbum == id).ToList();
                vm.Tracks = context.Tracks.Where(m => m.IdAlbum == id).ToList();
            }

            ViewBag.Cover = album.Cover;
            ViewBag.Name = album.Name;
            ViewBag.Style = album.Style;
            ViewBag.Artist = artist.Name;

            return View("Infos", vm);
        }

        [HttpPost]
        public ActionResult Comment(string Value, int idAlbum)
        {

            return Infos(idAlbum);
        }
    }
}