using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorMovieProj.Models;

namespace RazorMovieProj.Data
{
    public class RazorMovieProjContext : DbContext
    {
        public RazorMovieProjContext (DbContextOptions<RazorMovieProjContext> options)
            : base(options)
        {
        }

        public DbSet<RazorMovieProj.Models.Movie> Movie { get; set; } = default!;
    }
}
