using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CongThongTin.Data;
using CongThongTin.Models;
using Microsoft.AspNetCore.Authorization;

namespace CongThongTin.Controllers
{
    [Authorize]
    public class Admin_NumberTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Admin_NumberTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin_NumberType
        public async Task<IActionResult> Index()
        {
            return View(await _context.Number_Type.ToListAsync());
        }

        // GET: Admin_NumberType/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var number_Type = await _context.Number_Type
                .FirstOrDefaultAsync(m => m.Number_TypeID == id);
            if (number_Type == null)
            {
                return NotFound();
            }

            return View(number_Type);
        }

        // GET: Admin_NumberType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin_NumberType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Number_TypeID,Title,Content,cost")] Number_Type number_Type)
        {
            if (ModelState.IsValid)
            {
                _context.Add(number_Type);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(number_Type);
        }

        // GET: Admin_NumberType/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var number_Type = await _context.Number_Type.FindAsync(id);
            if (number_Type == null)
            {
                return NotFound();
            }
            return View(number_Type);
        }

        // POST: Admin_NumberType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Number_TypeID,Title,Content,cost")] Number_Type number_Type)
        {
            if (id != number_Type.Number_TypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(number_Type);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Number_TypeExists(number_Type.Number_TypeID))
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
            return View(number_Type);
        }

        // GET: Admin_NumberType/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var number_Type = await _context.Number_Type
                .FirstOrDefaultAsync(m => m.Number_TypeID == id);
            if (number_Type == null)
            {
                return NotFound();
            }

            return View(number_Type);
        }

        // POST: Admin_NumberType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var number_Type = await _context.Number_Type.FindAsync(id);
            _context.Number_Type.Remove(number_Type);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Number_TypeExists(string id)
        {
            return _context.Number_Type.Any(e => e.Number_TypeID == id);
        }
        public async Task<IActionResult> SortByName(string keyword)
        {
            var numbertype = _context.Number_Type.Where(p => p.Title.Contains(keyword));
            return View(await numbertype.ToListAsync());
        }
    }
}
