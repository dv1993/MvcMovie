using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieActor
    {
        public Guid ActorId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
}
