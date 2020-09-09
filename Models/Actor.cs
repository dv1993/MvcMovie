using System;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<MovieActor> MovieActors { get; set; }
    }
}