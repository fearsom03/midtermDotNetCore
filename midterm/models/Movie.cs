using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace midterm.models
{
    public class Movie
    {
        [Display(Name = "Name of movie")]
        public string name { get; set; }

        [Display(Name = "Discriptoin")]
        public string discriptoin { get; set; }

        [Display(Name = "Image")]
        public string postImageUrl { get; set; }

        [Display(Name = "Duration")]
        public int    durationInMinutes { get; set; }

        [Display(Name = "Ratings")]
        public List<Rating> ratings { get; set; }
    }
}
