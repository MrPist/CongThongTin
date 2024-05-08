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
    public class CuahangsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CuahangsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cuahangs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cuahang.ToListAsync());
        }
    }
}
