using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using midterm.models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace midterm.Controllers
{
    public class MoviesController : Controller
    {

        public IActionResult Index()
        {

            var ratings = new List<Rating> { new Rating { }, new Rating { } };
            var movies = new List<Movie>
        {
            new Movie { name = "Star Wars 1",discriptoin="some big discription of movie",postImageUrl="https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/joker_dabf394a-d4f2-4b68-90e2-011ed6b54012_poster.png?d=270x360&q=20",
                durationInMinutes =120,ratings = new List<Rating> { new Rating {authorName="Kuanysh",comment="Nice movie",rating=5}, new Rating { } }
        },
            new Movie {
                name = "Star Wars 2",discriptoin="some BIIG discription of movie",postImageUrl="https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/maleficent-mistress-of-evil_c8507e61-a6b3-404d-b8c5-df6f74bc62be_poster.png?d=270x360&q=20",
                durationInMinutes =389,ratings = null
            },
            new Movie {
                name = "Wars 2 Star",discriptoin="some LIIL discription of movie",postImageUrl="https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/the-lion-king_3904aadc-3a07-4836-892f-763b2dfdeea3_poster.png?d=270x360&q=20",
                durationInMinutes =78,ratings = null
            },
            new Movie {
                name = "Yes day",discriptoin="Nothing to say about big discription of movie",postImageUrl="https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/the-lion-king_3904aadc-3a07-4836-892f-763b2dfdeea3_poster.png?d=270x360&q=20",
                durationInMinutes =60,ratings = null
            },
        };


            return View(movies);
        }
    }
}
