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

        // GET: Packages/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Package
                .Include(p => p.PackageCateIDNavigation)
                .Include(p => p.PackageIDNavigation)
                .FirstOrDefaultAsync(m => m.Package_ID == id);
            if (package == null)
            {
                return NotFound();
            }

            return View(package);
        }

        // GET: Packages/Create
        public IActionResult Create()
        {
            ViewData["Package_CateID"] = new SelectList(_context.Set<Package_Cate>(), "Package_CateID", "Package_CateID");
            ViewData["PostCateID"] = new SelectList(_context.Post_cate, "PostCateID", "PostCateID");
            return View();
        }

        // POST: Packages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Package_ID,Package_title,Package_CateID,Package_content,PostCateID,cost,link")] Package package)
        {
            if (ModelState.IsValid)
            {
                _context.Add(package);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Package_CateID"] = new SelectList(_context.Set<Package_Cate>(), "Package_CateID", "Package_CateID", package.Package_CateID);
            ViewData["PostCateID"] = new SelectList(_context.Post_cate, "PostCateID", "PostCateID", package.PostCateID);
            return View(package);
        }

        // GET: Packages/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Package.FindAsync(id);
            if (package == null)
            {
                return NotFound();
            }
            ViewData["Package_CateID"] = new SelectList(_context.Set<Package_Cate>(), "Package_CateID", "Package_CateID", package.Package_CateID);
            ViewData["PostCateID"] = new SelectList(_context.Post_cate, "PostCateID", "PostCateID", package.PostCateID);
            return View(package);
        }

        // POST: Packages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Package_ID,Package_title,Package_CateID,Package_content,PostCateID,cost,link")] Package package)
        {
            if (id != package.Package_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(package);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PackageExists(package.Package_ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Package_CateID"] = new SelectList(_context.Set<Package_Cate>(), "Package_CateID", "Package_CateID", package.Package_CateID);
            ViewData["PostCateID"] = new SelectList(_context.Post_cate, "PostCateID", "PostCateID", package.PostCateID);
            return View(package);
        }

        // GET: Packages/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Package
                .Include(p => p.PackageCateIDNavigation)
                .Include(p => p.PackageIDNavigation)
                .FirstOrDefaultAsync(m => m.Package_ID == id);
            if (package == null)
            {
                return NotFound();
            }

            return View(package);
        }

        // POST: Packages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var package = await _context.Package.FindAsync(id);
            _context.Package.Remove(package);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PackageExists(string id)
        {
            return _context.Package.Any(e => e.Package_ID == id);
        }
    }
}
