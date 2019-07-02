using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetelloBusinessSolution.Data;
using NetelloBusinessSolution.FinacialManagement.ViewModels;
using NetelloBusinessSolution.Models;

namespace NetelloBusinessSolution.Controllers
{
    public class WorkReportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WorkReports
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.WorkReport.Include(w => w.AssignedFE).Include(w => w.BusinessCentre);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: WorkReports HttpPost !
        [HttpPost]
        public IActionResult Index(WorkReport workReport)
        {
            var applicationContext = _context.WorkReport.Include(w => w.AssignedFE).Include(w=> w.BusinessCentre);
            workReport.TotalPayment = workReport.TimeWorked * workReport.PaymentPerHour;
            workReport.DueToPay = workReport.TimeWorked * workReport.PaymentPerHour - workReport.AmountPayed;
            return View(workReport);
        }
        // GET: WorkReports to ListWR
        public IActionResult ListWR()
        {

            var workReports = _context.WorkReport.Select(w => w.Id);
            
            var workReportViewModel = new WorkReportViewModel()
            {
                WorkReports = _context.WorkReport.Where(w => w.Id !=0).Include(w => w.AssignedFE).Include(w=> w.BusinessCentre).ToList(),
                TotalTimeWorked = _context.WorkReport.Sum(w=> w.TimeWorked),
                TotalPayment = _context.WorkReport.Sum(w=> w.TotalPayment),
                TotalDueToPay = _context.WorkReport.Sum(w=> w.DueToPay)
            };
                        
            return View(workReportViewModel);
        }

        // GET: WorkReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workReport = await _context.WorkReport
                .Include(w => w.AssignedFE)
                .Include(w => w.BusinessCentre)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workReport == null)
            {
                return NotFound();
            }

            return View(workReport);
        }

        // GET: WorkReports/Create
        public IActionResult Create()
        {
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["BusinessCentreId"] = new SelectList(_context.BusinessCentre, "Id", "CwName");
            return View();
        }

        // POST: WorkReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BusinessCentreId,PersonId,WorkStarted,WorkEnded,TimeWorked,PaymentPerHour,TotalPayment,WorkNote,Payed,AmountPayed,DueToPay,DWorkinTicketNumber")] WorkReport workReport)
        {
            if (ModelState.IsValid)
            {
                var applicationContext = _context.WorkReport.Include(w => w.AssignedFE).Include(w => w.BusinessCentre);
                workReport.TotalPayment = workReport.TimeWorked * workReport.PaymentPerHour;
                workReport.DueToPay = workReport.TimeWorked * workReport.PaymentPerHour - workReport.AmountPayed;
                _context.Add(workReport);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", workReport.PersonId);
            ViewData["BusinessCentreId"] = new SelectList(_context.BusinessCentre, "Id", "CwName", workReport.BusinessCentreId);
            return View(workReport);
        }

        // GET: WorkReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workReport = await _context.WorkReport.FindAsync(id);
            if (workReport == null)
            {
                return NotFound();
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", workReport.PersonId);
            ViewData["BusinessCentreId"] = new SelectList(_context.BusinessCentre, "Id", "CwName", workReport.BusinessCentreId);
            return View(workReport);
        }

        // POST: WorkReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BusinessCentreId,PersonId,WorkStarted,WorkEnded,TimeWorked,PaymentPerHour,TotalPayment,WorkNote,Payed,AmountPayed,DueToPay,DWorkinTicketNumber")] WorkReport workReport)
        {
            if (id != workReport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var applicationContext = _context.WorkReport.Include(w => w.AssignedFE).Include(w => w.BusinessCentre);
                    workReport.TotalPayment = workReport.TimeWorked * workReport.PaymentPerHour;
                    workReport.DueToPay = workReport.TimeWorked * workReport.PaymentPerHour - workReport.AmountPayed;
                    _context.Update(workReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkReportExists(workReport.Id))
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
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", workReport.PersonId);
            ViewData["BusinessCentreId"] = new SelectList(_context.BusinessCentre, "Id", "CwName", workReport.BusinessCentreId);
            return View(workReport);
        }

        // GET: WorkReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workReport = await _context.WorkReport
                .Include(w => w.AssignedFE)
                .Include(w => w.BusinessCentre)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workReport == null)
            {
                return NotFound();
            }

            return View(workReport);
        }

        // POST: WorkReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workReport = await _context.WorkReport.FindAsync(id);
            _context.WorkReport.Remove(workReport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkReportExists(int id)
        {
            return _context.WorkReport.Any(e => e.Id == id);
        }
    }
}
