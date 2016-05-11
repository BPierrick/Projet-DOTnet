using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet.Models
{
    public class Tracks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdArtist { get; set; }
        public int IdAlbum { get; set; }
        public int Length { get; set; }

        public List<Albums> Albums { get; set; }
        public List<Artists> Artists { get; set; }
    }
}