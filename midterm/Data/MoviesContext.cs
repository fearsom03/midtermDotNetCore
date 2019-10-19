using System;
using Microsoft.EntityFrameworkCore;
using midterm.models;

namespace midterm.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> movies { get; set; }

        
    }

}
