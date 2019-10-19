using System;
using System.ComponentModel.DataAnnotations;

namespace midterm.models
{
    public class Rating
    {
        [Display(Name = "Author name")]
        public string authorName { get; set; }

        [Display(Name = "Comment")]
        public string comment { get; set; }

        [Display(Name = "Given rating")]
        public double rating { get; set; }

        [Display(Name = "Movie")]
        public Movie movie { get; set; }
    }
}
