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
    public class Admin_CuaHangController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Admin_CuaHangController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin_CuaHang
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cuahang.ToListAsync());
        }

        // GET: Admin_CuaHang/Details/5
        //public async Task<IActionResult> Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var cuahang = await _context.Cuahang
        //        .FirstOrDefaultAsync(m => m.MaCH == id);
        //    if (cuahang == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(cuahang);
        //}

        // GET: Admin_CuaHang/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin_CuaHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaCH,TenCH,DiaChi,IDmap")] Cuahang cuahang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cuahang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cuahang);
        }

        // GET: Admin_CuaHang/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuahang = await _context.Cuahang.FindAsync(id);
            if (cuahang == null)
            {
                return NotFound();
            }
            return View(cuahang);
        }

        // POST: Admin_CuaHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaCH,TenCH,DiaChi,IDmap")] Cuahang cuahang)
        {
            if (id != cuahang.MaCH)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cuahang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CuahangExists(cuahang.MaCH))
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
            return View(cuahang);
        }

        // GET: Admin_CuaHang/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuahang = await _context.Cuahang
                .FirstOrDefaultAsync(m => m.MaCH == id);
            if (cuahang == null)
            {
                return NotFound();
            }

            return View(cuahang);
        }

        // POST: Admin_CuaHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cuahang = await _context.Cuahang.FindAsync(id);
            _context.Cuahang.Remove(cuahang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CuahangExists(string id)
        {
            return _context.Cuahang.Any(e => e.MaCH == id);
        }
    }
}
