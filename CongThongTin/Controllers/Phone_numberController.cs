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
    public class Phone_numberController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Phone_numberController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Phone_number
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Phone_number.Include(p => p.Number_TypeIDNavigation).Include(p => p.Phone_numberIDNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> SortByName(string keyword)
        {

            var phone = _context.Phone_number.Where(p => p.Number.Contains(keyword));
            return View(await phone.ToListAsync());
        }

        private bool Phone_numberExists(string id)
        {
            return _context.Phone_number.Any(e => e.Number == id);
        }
    }
}
