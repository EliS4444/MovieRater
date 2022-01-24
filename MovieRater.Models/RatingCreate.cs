using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class RatingCreate
    {
        [Required]
        [Range(0,5)]
        public double Score { get; set; }
        [MaxLength(255)]
        public string Remarks { get; set; }
        public int MediaId { get; set; }
    }
}
