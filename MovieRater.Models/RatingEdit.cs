using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class RatingEdit
    {
        public int RatingId { get; set; }
        public double Score { get; set; }
        public string Remarks { get; set; }
    }
}