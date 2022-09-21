using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Goals_Site.Data;
using Goals_Site.Models;

namespace Goals_Site.Controllers
{
    public class Project_managerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Project_managerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Project_manager
        public async Task<IActionResult> Index()
        {
              return View(await _context.Project_manager.ToListAsync());
        }

        // GET: Project_manager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Project_manager == null)
            {
                return NotFound();
            }

            var project_manager = await _context.Project_manager
                .FirstOrDefaultAsync(m => m.Project_managerId == id);
            if (project_manager == null)
            {
                return NotFound();
            }

            return View(project_manager);
        }

        // GET: Project_manager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Project_manager/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Project_managerId,Name,Phone")] Project_manager project_manager)
        {
            if (ModelState.IsValid)
            {
                _context.Add(project_manager);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(project_manager);
        }

        // GET: Project_manager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Project_manager == null)
            {
                return NotFound();
            }

            var project_manager = await _context.Project_manager.FindAsync(id);
            if (project_manager == null)
            {
                return NotFound();
            }
            return View(project_manager);
        }

        // POST: Project_manager/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Project_managerId,Name,Phone")] Project_manager project_manager)
        {
            if (id != project_manager.Project_managerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project_manager);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Project_managerExists(project_manager.Project_managerId))
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
            return View(project_manager);
        }

        // GET: Project_manager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Project_manager == null)
            {
                return NotFound();
            }

            var project_manager = await _context.Project_manager
                .FirstOrDefaultAsync(m => m.Project_managerId == id);
            if (project_manager == null)
            {
                return NotFound();
            }

            return View(project_manager);
        }

        // POST: Project_manager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Project_manager == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Project_manager'  is null.");
            }
            var project_manager = await _context.Project_manager.FindAsync(id);
            if (project_manager != null)
            {
                _context.Project_manager.Remove(project_manager);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Project_managerExists(int id)
        {
          return _context.Project_manager.Any(e => e.Project_managerId == id);
        }
    }
}
