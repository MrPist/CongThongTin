    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CongThongTin.Data;
using CongThongTin.Models;

namespace CongThongTin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Home
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Post.Include(p => p.PostIDNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Home/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post
                .Include(p => p.PostIDNavigation)
                .FirstOrDefaultAsync(m => m.PostID == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        public async Task<IActionResult> SortByName(string keyword)
        {
            var post = _context.Post.Where(p => p.Post_title.Contains(keyword));
            return View(await post.ToListAsync());
        }
        public IActionResult Contact()
        {
            return View();
        }
        public async Task<IActionResult> Info()
        {
            var applicationDbContext = _context.Post.Include(p => p.PostIDNavigation);
            return View(await applicationDbContext.ToListAsync());
        }
        private bool PostExists(string id)
        {
            return _context.Post.Any(e => e.PostID == id);
        }
    }
}
