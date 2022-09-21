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
    public class Sales_managerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Sales_managerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sales_manager
        public async Task<IActionResult> Index()
        {
              return View(await _context.Sales_manager.ToListAsync());
        }

        // GET: Sales_manager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sales_manager == null)
            {
                return NotFound();
            }

            var sales_manager = await _context.Sales_manager
                .FirstOrDefaultAsync(m => m.Sales_managerId == id);
            if (sales_manager == null)
            {
                return NotFound();
            }

            return View(sales_manager);
        }

        // GET: Sales_manager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sales_manager/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Sales_managerId,Name,Phone")] Sales_manager sales_manager)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sales_manager);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sales_manager);
        }

        // GET: Sales_manager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sales_manager == null)
            {
                return NotFound();
            }

            var sales_manager = await _context.Sales_manager.FindAsync(id);
            if (sales_manager == null)
            {
                return NotFound();
            }
            return View(sales_manager);
        }

        // POST: Sales_manager/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Sales_managerId,Name,Phone")] Sales_manager sales_manager)
        {
            if (id != sales_manager.Sales_managerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sales_manager);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Sales_managerExists(sales_manager.Sales_managerId))
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
            return View(sales_manager);
        }

        // GET: Sales_manager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sales_manager == null)
            {
                return NotFound();
            }

            var sales_manager = await _context.Sales_manager
                .FirstOrDefaultAsync(m => m.Sales_managerId == id);
            if (sales_manager == null)
            {
                return NotFound();
            }

            return View(sales_manager);
        }

        // POST: Sales_manager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sales_manager == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Sales_manager'  is null.");
            }
            var sales_manager = await _context.Sales_manager.FindAsync(id);
            if (sales_manager != null)
            {
                _context.Sales_manager.Remove(sales_manager);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Sales_managerExists(int id)
        {
          return _context.Sales_manager.Any(e => e.Sales_managerId == id);
        }
    }
}
