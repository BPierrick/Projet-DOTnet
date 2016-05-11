using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet.Models
{
    public class Albums
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdArtist { get; set; }
        public string Style { get; set; }
        public string Cover { get; set; }

        public List<Artists> Artists { get; set;}
        public List<Tracks> Tracks { get; set; }
    }
}