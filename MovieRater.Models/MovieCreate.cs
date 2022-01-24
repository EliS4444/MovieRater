using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class MovieCreate
    {
        [Required]
        public string MovieName { get; set; }
        [Required]
        [MaxLength(8000, ErrorMessage ="Limit for description is 8000 characters.")]
        public string MovieDescription { get; set; }

    }
}
