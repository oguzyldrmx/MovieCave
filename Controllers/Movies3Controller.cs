using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieCave.Data;
using MovieCave.Models;

namespace MovieCave.Controllers
{
    public class Movies3Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Movies3Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Movies3
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Movies.Include(m => m.Categories);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Movies3/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movies = await _context.Movies
                .Include(m => m.Categories)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movies == null)
            {
                return NotFound();
            }

            return View(movies);
        }

    }
}
