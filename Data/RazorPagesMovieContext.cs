using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options) : base(options){}
        
        
    }
}
