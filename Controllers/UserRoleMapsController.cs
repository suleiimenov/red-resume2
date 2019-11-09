using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using red_resume.Data;
using red_resume.Models.UserRoleMap;

namespace red_resume.Controllers
{
    public class UserRoleMapsController : Controller
    {
        private readonly DBContext _context;

        public UserRoleMapsController(DBContext context)
        {
            _context = context;
        }

        // GET: UserRoleMaps
        public async Task<IActionResult> Index()
        {
<<<<<<< HEAD
            var dBContext = _context.UserRoleMap.Include(u => u.Role).Include(u => u.User);
            return View(await dBContext.ToListAsync());
=======
            return View(await _context.UserRoleMap.ToListAsync());
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
        }

        // GET: UserRoleMaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRoleMap = await _context.UserRoleMap
<<<<<<< HEAD
                .Include(u => u.Role)
                .Include(u => u.User)
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userRoleMap == null)
            {
                return NotFound();
            }

            return View(userRoleMap);
        }

        // GET: UserRoleMaps/Create
        public IActionResult Create()
        {
<<<<<<< HEAD
            ViewData["roleId"] = new SelectList(_context.Role, "Id", "Name");
            ViewData["userId"] = new SelectList(_context.User, "Id", "Name");
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View();
        }

        // POST: UserRoleMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Create([Bind("Id,userId,roleId")] UserRoleMap userRoleMap)
=======
        public async Task<IActionResult> Create([Bind("Id")] UserRoleMap userRoleMap)
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRoleMap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
<<<<<<< HEAD
            ViewData["roleId"] = new SelectList(_context.Role, "Id", "Name", userRoleMap.roleId);
            ViewData["userId"] = new SelectList(_context.User, "Id", "Name", userRoleMap.userId);
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View(userRoleMap);
        }

        // GET: UserRoleMaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRoleMap = await _context.UserRoleMap.FindAsync(id);
            if (userRoleMap == null)
            {
                return NotFound();
            }
<<<<<<< HEAD
            ViewData["roleId"] = new SelectList(_context.Role, "Id", "Name", userRoleMap.roleId);
            ViewData["userId"] = new SelectList(_context.User, "Id", "Name", userRoleMap.userId);
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View(userRoleMap);
        }

        // POST: UserRoleMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Edit(int id, [Bind("Id,userId,roleId")] UserRoleMap userRoleMap)
=======
        public async Task<IActionResult> Edit(int id, [Bind("Id")] UserRoleMap userRoleMap)
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
        {
            if (id != userRoleMap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userRoleMap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserRoleMapExists(userRoleMap.Id))
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
            ViewData["roleId"] = new SelectList(_context.Role, "Id", "Name", userRoleMap.roleId);
            ViewData["userId"] = new SelectList(_context.User, "Id", "Name", userRoleMap.userId);
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View(userRoleMap);
        }

        // GET: UserRoleMaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRoleMap = await _context.UserRoleMap
<<<<<<< HEAD
                .Include(u => u.Role)
                .Include(u => u.User)
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userRoleMap == null)
            {
                return NotFound();
            }

            return View(userRoleMap);
        }

        // POST: UserRoleMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userRoleMap = await _context.UserRoleMap.FindAsync(id);
            _context.UserRoleMap.Remove(userRoleMap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserRoleMapExists(int id)
        {
            return _context.UserRoleMap.Any(e => e.Id == id);
        }
    }
}
