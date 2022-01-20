using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Data
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public double Score { get; set; }
        [Required]
        [Display(Name ="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
