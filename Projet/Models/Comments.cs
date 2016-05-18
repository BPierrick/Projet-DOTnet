using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public int IdArtist { get; set; }
        public int IdAlbum { get; set; }
        public int IdTrack { get; set; }
        public int IdUser { get; set; }
        public string Value { get; set; }

        public List<Albums> Albums { get; set; }
        public List<Artists> Artists { get; set; }
    }
}