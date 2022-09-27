using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Goals_Site.Data;
using Goals_Site.Models;
using System.Drawing.Printing;
using Microsoft.AspNetCore.Http;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Goals_Site.Controllers
{
    public class JobsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JobsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Jobs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Job.Include(j => j.Client).Include(j => j.Project_manager).Include(j => j.Sales_manager);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Jobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Job == null)
            {
                return NotFound();
            }

            var job = await _context.Job
                .Include(j => j.Client)
                .Include(j => j.Project_manager)
                .Include(j => j.Sales_manager)
                .FirstOrDefaultAsync(m => m.JobId == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // GET: Jobs/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "Name");
            ViewData["Project_managerId"] = new SelectList(_context.Project_manager, "Project_managerId", "Name");
            ViewData["Sales_managerId"] = new SelectList(_context.Sales_manager, "Sales_managerId", "Name");
            return View();
        }

        // POST: Jobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobId,Job_number,Date,Start,Est_finish_time,Scope,Project_managerId,Sales_managerId,ClientId,From_site,To_site")] Job job)
        {
            //if (ModelState.IsValid)
            //{
                
                _context.Add(job);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            //}
            
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", job.ClientId);
            ViewData["Project_managerId"] = new SelectList(_context.Project_manager, "Project_managerId", "Project_managerId", job.Project_managerId);
            ViewData["Sales_managerId"] = new SelectList(_context.Sales_manager, "Sales_managerId", "Sales_managerId", job.Sales_managerId);
            return View(job);
        }

        // GET: Jobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Job == null)
            {
                return NotFound();
            }

            var job = await _context.Job.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", job.ClientId);
            ViewData["Project_managerId"] = new SelectList(_context.Project_manager, "Project_managerId", "Project_managerId", job.Project_managerId);
            ViewData["Sales_managerId"] = new SelectList(_context.Sales_manager, "Sales_managerId", "Sales_managerId", job.Sales_managerId);
            return View(job);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobId,Job_number,Date,Start,Est_finish_time,Scope,Project_managerId,Sales_managerId,ClientId,From_site,To_site")] Job job)
        {
            if (id != job.JobId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(job);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobExists(job.JobId))
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
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", job.ClientId);
            ViewData["Project_managerId"] = new SelectList(_context.Project_manager, "Project_managerId", "Project_managerId", job.Project_managerId);
            ViewData["Sales_managerId"] = new SelectList(_context.Sales_manager, "Sales_managerId", "Sales_managerId", job.Sales_managerId);
            return View(job);
        }

        // GET: Jobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Job == null)
            {
                return NotFound();
            }

            var job = await _context.Job
                .Include(j => j.Client)
                .Include(j => j.Project_manager)
                .Include(j => j.Sales_manager)
                .FirstOrDefaultAsync(m => m.JobId == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // POST: Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Job == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Job'  is null.");
            }
            var job = await _context.Job.FindAsync(id);
            if (job != null)
            {
                _context.Job.Remove(job);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST Create Job Document
        [HttpPost, ActionName("Document")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Document()
        {
            using (var doc = WordprocessingDocument.Create("TestAddText.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = doc.AddMainDocumentPart();
                mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();

                Body body = mainPart.Document.AppendChild(new Body());

                Paragraph para = body.AppendChild(new Paragraph());

                DocumentFormat.OpenXml.Wordprocessing.Run run = para.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Run());

                run.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Text("this is a new Document"));
            }
            return View("Index");
        }

        private bool JobExists(int id)
        {
          return _context.Job.Any(e => e.JobId == id);
        }
    }
}
