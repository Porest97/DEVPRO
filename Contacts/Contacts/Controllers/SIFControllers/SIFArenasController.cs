using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Contacts.Models;
using Contacts.Models.SIFModels;

namespace Contacts.Controllers.SIFControllers
{
    public class SIFArenasController : Controller
    {
        private readonly ContactsContext _context;

        public SIFArenasController(ContactsContext context)
        {
            _context = context;
        }

        // GET: SIFArenas
        public async Task<IActionResult> Index(String searchString)

        {
            var model = from a in _context.SIFArena
                        select a;

            if (!String.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                model = _context.SIFArena.Where(a => a.ArenanDistrict.ToLower().Contains(searchString));
            }
            return View(await model.ToListAsync());
        }

        // GET: SIFArenas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sIFArena = await _context.SIFArena
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sIFArena == null)
            {
                return NotFound();
            }

            return View(sIFArena);
        }

        // GET: SIFArenas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SIFArenas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ArenaNumber,ArenanName,ArenanAddress,ArenanZipCode,ArenanCity,ArenanCountry,ArenanDistrict,ArenanCategory,ArenanPhoneNumbers,ArenanCapacity,ArenanStanding,ArenanBench,ArenanChair,ArenanSoftChair,ArenanHandicapSlots,ArenanBuildYear,ArenanReBuildYear,ArenanLatestInspected,ArenanLastChecked")] SIFArena sIFArena)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sIFArena);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sIFArena);
        }

        // GET: SIFArenas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sIFArena = await _context.SIFArena.FindAsync(id);
            if (sIFArena == null)
            {
                return NotFound();
            }
            return View(sIFArena);
        }

        // POST: SIFArenas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ArenaNumber,ArenanName,ArenanAddress,ArenanZipCode,ArenanCity,ArenanCountry,ArenanDistrict,ArenanCategory,ArenanPhoneNumbers,ArenanCapacity,ArenanStanding,ArenanBench,ArenanChair,ArenanSoftChair,ArenanHandicapSlots,ArenanBuildYear,ArenanReBuildYear,ArenanLatestInspected,ArenanLastChecked")] SIFArena sIFArena)
        {
            if (id != sIFArena.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sIFArena);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SIFArenaExists(sIFArena.Id))
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
            return View(sIFArena);
        }

        // GET: SIFArenas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sIFArena = await _context.SIFArena
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sIFArena == null)
            {
                return NotFound();
            }

            return View(sIFArena);
        }

        // POST: SIFArenas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sIFArena = await _context.SIFArena.FindAsync(id);
            _context.SIFArena.Remove(sIFArena);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SIFArenaExists(int id)
        {
            return _context.SIFArena.Any(e => e.Id == id);
        }
    }
}
