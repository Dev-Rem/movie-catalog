using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    /// <summary> Class <c> MvcMovieContext </c>  creates a DbSet<Movie> property for the entity set </summary>
    public class MvcMovieContext : DbContext
    {
        /// <summary> Constructor <c> MvcMovieContext </c> </summary>
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        
        }
        public DbSet<Movie> Movie { get; set; }
    }
}