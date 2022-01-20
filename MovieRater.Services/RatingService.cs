using MovieRater.Data;
using MovieRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Services
{
    public class RatingService
    {
        private readonly Guid _userId;

        public RatingService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateRating(RatingCreate model)
        {
            var entity =
                new Rating()
                {
                    OwnerId = _userId,
                    Score = model.Score,
                    Remarks = model.Remarks,
                    CreatedUtc = DateTimeOffset.Now,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Ratings.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<RatingListItem> GetRatingsByUser()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Ratings.Where(e => e.OwnerId == _userId)
                    .Select(e => new RatingListItem
                    {
                        RatingId = e.RatingId,
                        Score = e.Score,
                        Remarks = e.Remarks,
                        CreatedUtc = e.CreatedUtc
                    });

                return query.ToList();
            }
        }

    }
}
