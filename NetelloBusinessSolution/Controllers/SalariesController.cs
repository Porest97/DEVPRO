using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetelloBusinessSolution.Data;
using NetelloBusinessSolution.Models.TestModels;

namespace NetelloBusinessSolution.Controllers
{
    public class SalariesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalariesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Salaries
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Salary.Include(s => s.Article).Include(s => s.Emplyee);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Salaries
        [HttpPost]
        public async Task<IActionResult> Index(Salary salary)
        {
            var applicationDbContext = _context.Salary.Include(s => s.Article).Include(s => s.Emplyee);
            salary.Total = salary.Hours * salary.Price;
            salary.AmountDueToPayOut = salary.Total - salary.AmountPayedOut;


            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Salaries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salary = await _context.Salary
                .Include(s => s.Article)
                .Include(s => s.Emplyee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salary == null)
            {
                return NotFound();
            }

            return View(salary);
        }

        // GET: Salaries/Create
        public IActionResult Create()
        {
            ViewData["ArticleId"] = new SelectList(_context.Article, "Id", "ArticleDescription");
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName");
            return View();
        }

        // POST: Salaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PeriodStartDate,PeriodEndDate,PersonId,ArticleId,Hours,Price,Total,PayedOut,AmountPayedOut,DatePayedOut,AmountDueToPayOut")] Salary salary)
        {
            if (ModelState.IsValid)
            {
                var applicationDbContext = _context.Salary.Include(s => s.Article).Include(s => s.Emplyee);
                salary.Total = salary.Hours * salary.Price;
                salary.AmountDueToPayOut = salary.Total - salary.AmountPayedOut;

                _context.Add(salary);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArticleId"] = new SelectList(_context.Article, "Id", "ArticleDescription", salary.ArticleId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", salary.PersonId);
            return View(salary);
        }

        // GET: Salaries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salary = await _context.Salary.FindAsync(id);
            if (salary == null)
            {
                return NotFound();
            }
            ViewData["ArticleId"] = new SelectList(_context.Article, "Id", "ArticleDescription", salary.ArticleId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", salary.PersonId);
            return View(salary);
        }

        // POST: Salaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PeriodStartDate,PeriodEndDate,PersonId,ArticleId,Hours,Price,Total,PayedOut,AmountPayedOut,DatePayedOut,AmountDueToPayOut")] Salary salary)
        {
            if (id != salary.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var applicationDbContext = _context.Salary.Include(s => s.Article).Include(s => s.Emplyee);
                    salary.Total = salary.Hours * salary.Price;
                    salary.AmountDueToPayOut = salary.Total - salary.AmountPayedOut;

                    _context.Update(salary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalaryExists(salary.Id))
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
            ViewData["ArticleId"] = new SelectList(_context.Article, "Id", "ArticleDescription", salary.ArticleId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", salary.PersonId);
            return View(salary);
        }

        // GET: Salaries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salary = await _context.Salary
                .Include(s => s.Article)
                .Include(s => s.Emplyee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salary == null)
            {
                return NotFound();
            }

            return View(salary);
        }

        // POST: Salaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salary = await _context.Salary.FindAsync(id);
            _context.Salary.Remove(salary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalaryExists(int id)
        {
            return _context.Salary.Any(e => e.Id == id);
        }
    }
}
