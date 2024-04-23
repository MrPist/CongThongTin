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
    public class PackagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PackagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Packages
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Package.Include(p => p.PackageCateIDNavigation).Include(p => p.PackageIDNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> SortByName(string keyword)
        {
            var package = _context.Package.Where(p => p.Package_ID.Contains(keyword));
            return View(await package.ToListAsync());
        }
        private bool PackageExists(string id)
        {
            return _context.Package.Any(e => e.Package_ID == id);
        }
    }
}
