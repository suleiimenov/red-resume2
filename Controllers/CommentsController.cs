using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using red_resume.Data;
using red_resume.Models.Comment;

namespace red_resume.Controllers
{
    public class CommentsController : Controller
    {
        private readonly DBContext _context;

        public CommentsController(DBContext context)
        {
            _context = context;
        }

        // GET: Comments
        public async Task<IActionResult> Index()
        {
<<<<<<< HEAD
            var dBContext = _context.Comment.Include(c => c.Task);
            return View(await dBContext.ToListAsync());
=======
            return View(await _context.Comment.ToListAsync());
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
        }

        // GET: Comments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comment
<<<<<<< HEAD
                .Include(c => c.Task)
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // GET: Comments/Create
        public IActionResult Create()
        {
<<<<<<< HEAD
            ViewData["TaskId"] = new SelectList(_context.Task, "Id", "Id");
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View();
        }

        // POST: Comments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Create([Bind("Id,Name,TaskId")] Comment comment)
=======
        public async Task<IActionResult> Create([Bind("Id,Name")] Comment comment)
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
        {
            if (ModelState.IsValid)
            {
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
<<<<<<< HEAD
            ViewData["TaskId"] = new SelectList(_context.Task, "Id", "Id", comment.TaskId);
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View(comment);
        }

        // GET: Comments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comment.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
<<<<<<< HEAD
            ViewData["TaskId"] = new SelectList(_context.Task, "Id", "Id", comment.TaskId);
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View(comment);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,TaskId")] Comment comment)
=======
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Comment comment)
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
        {
            if (id != comment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(comment.Id))
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
            ViewData["TaskId"] = new SelectList(_context.Task, "Id", "Id", comment.TaskId);
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
            return View(comment);
        }

        // GET: Comments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comment
<<<<<<< HEAD
                .Include(c => c.Task)
=======
>>>>>>> 245ae373ac5dd32ce8cef7123abd583b794baa87
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comment = await _context.Comment.FindAsync(id);
            _context.Comment.Remove(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentExists(int id)
        {
            return _context.Comment.Any(e => e.Id == id);
        }
    }
}
