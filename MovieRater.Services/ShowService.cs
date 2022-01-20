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
        private readonly Guid _userId;

        public ShowService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateShow(ShowCreate model)
        {
            Show entity =
                new Show()
                {
                    Title = model.ShowName,
                    Description = model.Description,
                    CreatedUtc = DateTime.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Media.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }


    }

    /*public ShowDetail GetShowByName(int id)
    {
        using (var ctx = new ApplicationDbContext())
        {
            var entity =
                ctx
                .Shows
                .Single(e => e.ShowId == id);
            return
                new ShowDetail
                {
                    ShowId = entity.ShowId,
                    ShowName = entity.ShowName,
                    Description = entity.Description,
                    CreatedUtc = entity.CreatedUtc,
                    ModifiedUtc = entity.ModifiedUtc
                };
        }
    }*/
}

