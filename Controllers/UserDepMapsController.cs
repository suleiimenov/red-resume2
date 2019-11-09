using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using red_resume.Data;
using red_resume.Models.UserDepMap;

namespace red_resume.Controllers
{
    public class UserDepMapsController : Controller
    {
        private readonly DBContext _context;

        public UserDepMapsController(DBContext context)
        {
            _context = context;
        }

        // GET: UserDepMaps
        public async Task<IActionResult> Index()
        {
<<<<<<< HEAD
            var dBContext = _context.UserDepMap.Include(u => u.Department).Include(u => u.User);
            return View(await dBContext.ToListAsync());
=======
            return View(await _context.UserDepMap.ToListAsync());
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
        }

        // GET: UserDepMaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDepMap = await _context.UserDepMap
<<<<<<< HEAD
                .Include(u => u.Department)
                .Include(u => u.User)
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userDepMap == null)
            {
                return NotFound();
            }

            return View(userDepMap);
        }

        // GET: UserDepMaps/Create
        public IActionResult Create()
        {
<<<<<<< HEAD
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Name");
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View();
        }

        // POST: UserDepMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Create([Bind("Id,Status,UserId,DepartmentId")] UserDepMap userDepMap)
=======
        public async Task<IActionResult> Create([Bind("Id,Status")] UserDepMap userDepMap)
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
        {
            if (ModelState.IsValid)
            {
                _context.Add(userDepMap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
<<<<<<< HEAD
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Id", userDepMap.DepartmentId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Name", userDepMap.UserId);
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View(userDepMap);
        }

        // GET: UserDepMaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDepMap = await _context.UserDepMap.FindAsync(id);
            if (userDepMap == null)
            {
                return NotFound();
            }
<<<<<<< HEAD
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Id", userDepMap.DepartmentId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Name", userDepMap.UserId);
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View(userDepMap);
        }

        // POST: UserDepMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Edit(int id, [Bind("Id,Status,UserId,DepartmentId")] UserDepMap userDepMap)
=======
        public async Task<IActionResult> Edit(int id, [Bind("Id,Status")] UserDepMap userDepMap)
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
        {
            if (id != userDepMap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userDepMap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserDepMapExists(userDepMap.Id))
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
<<<<<<< HEAD
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Id", userDepMap.DepartmentId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Name", userDepMap.UserId);
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View(userDepMap);
        }

        // GET: UserDepMaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDepMap = await _context.UserDepMap
<<<<<<< HEAD
                .Include(u => u.Department)
                .Include(u => u.User)
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userDepMap == null)
            {
                return NotFound();
            }

            return View(userDepMap);
        }

        // POST: UserDepMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userDepMap = await _context.UserDepMap.FindAsync(id);
            _context.UserDepMap.Remove(userDepMap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserDepMapExists(int id)
        {
            return _context.UserDepMap.Any(e => e.Id == id);
        }
    }
}
