 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorMovieProj.Data;
using RazorMovieProj.Models;

namespace RazorMovieProj.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorMovieProj.Data.RazorMovieProjContext _context;

        public IndexModel(RazorMovieProj.Data.RazorMovieProjContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
