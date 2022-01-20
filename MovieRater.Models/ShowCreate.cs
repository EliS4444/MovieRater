using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class ShowCreate
    {
        [Required]
        public string ShowName { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }       
    }
}
