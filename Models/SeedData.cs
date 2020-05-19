using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;
namespace RazorPagesMovie.Models
{
    public  static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider){
            using(var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if(context.Movie.Any()){
                    return;
                }

                context.Movie.AddRange(
                    new Movie{
                        Title = "When Harry Met Sally",
                        RealesedDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99m,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        RealesedDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99m,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        RealesedDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99m,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        RealesedDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99m,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
