using MovieRater.Data;
using MovieRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Services
{
    public class MovieService
    {
        public bool CreateMovie(MovieCreate model)
        {
            var entity =
                new Movie()
                {
                    MovieName = model.MovieName,
                    MovieDescription = model.MovieDescription,
                    CreatedUtc = DateTime.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Movies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
