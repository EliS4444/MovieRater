using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Data
{
    public class Show
    {
        [Key]
        public int ShowId { get; set; }
        [Required]
        public string ShowName { get; set; }
        [Required]
        public string Description { get; set; }
        public string EpisodeCount { get; set; }
        public string SeasonCount { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }

    }
}
