using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class RatingListItem
    {
        public int RatingId { get; set; }
        public double Score { get; set; }
        public string Remarks { get; set; }
        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
