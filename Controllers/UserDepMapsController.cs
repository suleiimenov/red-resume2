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
            var dBContext = _context.UserDepMap.Include(u => u.Department).Include(u => u.User);
            return View(await dBContext.ToListAsync());
        }

        // GET: UserDepMaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDepMap = await _context.UserDepMap
                .Include(u => u.Department)
                .Include(u => u.User)
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
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Name");
            return View();
        }

        // POST: UserDepMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Status,UserId,DepartmentId")] UserDepMap userDepMap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userDepMap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Id", userDepMap.DepartmentId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Name", userDepMap.UserId);
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
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Id", userDepMap.DepartmentId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Name", userDepMap.UserId);
            return View(userDepMap);
        }

        // POST: UserDepMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Status,UserId,DepartmentId")] UserDepMap userDepMap)
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
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Id", userDepMap.DepartmentId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Name", userDepMap.UserId);
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
                .Include(u => u.Department)
                .Include(u => u.User)
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
