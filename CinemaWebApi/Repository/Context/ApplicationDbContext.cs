using CinemaWebApi.Domain.Entities.Movie;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
    }
}
