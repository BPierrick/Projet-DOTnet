using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet.Models
{
    public class Artists
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Albums> Albums { get; set; }
        public List<Tracks> Tracks { get; set; }
        public List<Comments> Comments { get; set; }
    }
}