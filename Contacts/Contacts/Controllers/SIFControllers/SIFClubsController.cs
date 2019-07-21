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
    public class SIFClubsController : Controller
    {
        private readonly ContactsContext _context;

        public SIFClubsController(ContactsContext context)
        {
            _context = context;
        }

        // GET: SIFClubs
        public async Task<IActionResult> Index(String searchString)
        {
            var model = from c in _context.SIFClub
                        select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                model = _context.SIFClub.Where(c => c.ClubDistrict.ToLower().Contains(searchString));
            }
            return View(await model.ToListAsync());
        }

        // GET: SIFClubs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sIFClub = await _context.SIFClub
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sIFClub == null)
            {
                return NotFound();
            }

            return View(sIFClub);
        }

        // GET: SIFClubs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SIFClubs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClubNumber,ClubName,ShortName,ClubAddress,ClubCity,ClubCountry,ClubDistrict,Organizer,HomeArena,ActiveIOL,Status,ClubNote")] SIFClub sIFClub)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sIFClub);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sIFClub);
        }

        // GET: SIFClubs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sIFClub = await _context.SIFClub.FindAsync(id);
            if (sIFClub == null)
            {
                return NotFound();
            }
            return View(sIFClub);
        }

        // POST: SIFClubs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClubNumber,ClubName,ShortName,ClubAddress,ClubCity,ClubCountry,ClubDistrict,Organizer,HomeArena,ActiveIOL,Status,ClubNote")] SIFClub sIFClub)
        {
            if (id != sIFClub.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sIFClub);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SIFClubExists(sIFClub.Id))
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
            return View(sIFClub);
        }

        // GET: SIFClubs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sIFClub = await _context.SIFClub
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sIFClub == null)
            {
                return NotFound();
            }

            return View(sIFClub);
        }

        // POST: SIFClubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sIFClub = await _context.SIFClub.FindAsync(id);
            _context.SIFClub.Remove(sIFClub);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SIFClubExists(int id)
        {
            return _context.SIFClub.Any(e => e.Id == id);
        }
    }
}
