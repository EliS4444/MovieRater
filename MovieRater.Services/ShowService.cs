using MovieRater.Data;
using MovieRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Services
{
    public class ShowService
    {
        public bool CreateShow(ShowCreate model)
        {
            var entity =
                new Show()
                {
                    ShowName = model.ShowName,
                    Description = model.Description,
                    CreatedUtc = DateTime.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Shows.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
