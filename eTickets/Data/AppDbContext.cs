using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorAndMovie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<ActorAndMovie>().HasOne(m => m.Movie).WithMany(am => am.ActorsAndMovies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<ActorAndMovie>().HasOne(m => m.Actor).WithMany(am => am.ActorsAndMovies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder); 
        }
        public DbSet<Actor> Actors  { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorAndMovie> ActorsAndMovies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

    }
}
