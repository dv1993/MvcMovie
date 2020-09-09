using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System.Linq;
using static MvcMovie.Models.Movie;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<MovieActor>().HasKey(x => new { x.ActorId, x.MovieId });
            modelBuilder.Entity<MovieActor>()
                .HasOne(x => x.Movie)
                .WithMany(x => x.MovieActors);

            modelBuilder.Entity<MovieActor>()
                .HasOne(x => x.Actor)
                .WithMany(x => x.MovieActors);

        }

        public DbSet<MovieActor> MovieActor { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor> Actor { get; set; }


    }
}