using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using red_resume.Data;
using red_resume.Models.Task;

namespace red_resume.Controllers
{
    public class TasksController : Controller
    {
        private readonly DBContext _context;

        public TasksController(DBContext context)
        {
            _context = context;
        }

        // GET: Tasks
        public async Task<IActionResult> Index()
        {
<<<<<<< HEAD
            var dBContext = _context.Task.Include(t => t.UserDepMap);
            return View(await dBContext.ToListAsync());
=======
            return View(await _context.Task.ToListAsync());
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
        }

        // GET: Tasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = await _context.Task
<<<<<<< HEAD
                .Include(t => t.UserDepMap)
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
                .FirstOrDefaultAsync(m => m.Id == id);
            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
<<<<<<< HEAD
            ViewData["UserDepMapId"] = new SelectList(_context.UserDepMap, "Id", "Id");
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Create([Bind("Id,Name,Description,UserDepMapId")] red_resume.Models.Task.Task task)
=======
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] red_resume.Models.Task.Task task)
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
        {
            if (ModelState.IsValid)
            {
                _context.Add(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
<<<<<<< HEAD
            ViewData["UserDepMapId"] = new SelectList(_context.UserDepMap, "Id", "Name", task.Name);
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View(task);
        }

        // GET: Tasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = await _context.Task.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
<<<<<<< HEAD
            ViewData["UserDepMapId"] = new SelectList(_context.UserDepMap, "Id", "Id", task.UserDepMapId);
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View(task);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,UserDepMapId")] red_resume.Models.Task.Task task)
=======
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] red_resume.Models.Task.Task task)
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
        {
            if (id != task.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(task);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskExists(task.Id))
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
            ViewData["UserDepMapId"] = new SelectList(_context.UserDepMap, "Id", "Id", task.UserDepMapId);
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View(task);
        }

        // GET: Tasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = await _context.Task
<<<<<<< HEAD
                .Include(t => t.UserDepMap)
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
                .FirstOrDefaultAsync(m => m.Id == id);
            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var task = await _context.Task.FindAsync(id);
            _context.Task.Remove(task);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskExists(int id)
        {
            return _context.Task.Any(e => e.Id == id);
        }
    }
}
