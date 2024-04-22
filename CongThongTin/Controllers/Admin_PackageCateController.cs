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
    public class Admin_PackageCateController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Admin_PackageCateController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin_PackageCate
        public async Task<IActionResult> Index()
        {
            return View(await _context.Package_Cate.ToListAsync());
        }

        // GET: Admin_PackageCate/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package_Cate = await _context.Package_Cate
                .FirstOrDefaultAsync(m => m.Package_CateID == id);
            if (package_Cate == null)
            {
                return NotFound();
            }

            return View(package_Cate);
        }

        // GET: Admin_PackageCate/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin_PackageCate/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Package_CateID,Package_name")] Package_Cate package_Cate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(package_Cate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(package_Cate);
        }

        // GET: Admin_PackageCate/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package_Cate = await _context.Package_Cate.FindAsync(id);
            if (package_Cate == null)
            {
                return NotFound();
            }
            return View(package_Cate);
        }

        // POST: Admin_PackageCate/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Package_CateID,Package_name")] Package_Cate package_Cate)
        {
            if (id != package_Cate.Package_CateID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(package_Cate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Package_CateExists(package_Cate.Package_CateID))
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
            return View(package_Cate);
        }

        // GET: Admin_PackageCate/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package_Cate = await _context.Package_Cate
                .FirstOrDefaultAsync(m => m.Package_CateID == id);
            if (package_Cate == null)
            {
                return NotFound();
            }

            return View(package_Cate);
        }

        // POST: Admin_PackageCate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var package_Cate = await _context.Package_Cate.FindAsync(id);
            _context.Package_Cate.Remove(package_Cate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Package_CateExists(string id)
        {
            return _context.Package_Cate.Any(e => e.Package_CateID == id);
        }
    }
}
