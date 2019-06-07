using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROContacts.Models;

namespace PROContacts.Controllers
{
    public class AgeGroupsController : Controller
    {
        private readonly PROContactsContext _context;

        public AgeGroupsController(PROContactsContext context)
        {
            _context = context;
        }

        // GET: AgeGroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.AgeGroup.ToListAsync());
        }

        // GET: AgeGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ageGroup = await _context.AgeGroup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ageGroup == null)
            {
                return NotFound();
            }

            return View(ageGroup);
        }

        // GET: AgeGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AgeGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AgeGroupName")] AgeGroup ageGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ageGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ageGroup);
        }

        // GET: AgeGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ageGroup = await _context.AgeGroup.FindAsync(id);
            if (ageGroup == null)
            {
                return NotFound();
            }
            return View(ageGroup);
        }

        // POST: AgeGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AgeGroupName")] AgeGroup ageGroup)
        {
            if (id != ageGroup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ageGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgeGroupExists(ageGroup.Id))
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
            return View(ageGroup);
        }

        // GET: AgeGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ageGroup = await _context.AgeGroup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ageGroup == null)
            {
                return NotFound();
            }

            return View(ageGroup);
        }

        // POST: AgeGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ageGroup = await _context.AgeGroup.FindAsync(id);
            _context.AgeGroup.Remove(ageGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgeGroupExists(int id)
        {
            return _context.AgeGroup.Any(e => e.Id == id);
        }
    }
}
