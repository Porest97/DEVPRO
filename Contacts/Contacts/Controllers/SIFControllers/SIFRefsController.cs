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
    public class SIFRefsController : Controller
    {
        private readonly ContactsContext _context;

        public SIFRefsController(ContactsContext context)
        {
            _context = context;
        }

        // GET: SIFRefs
        public async Task<IActionResult> Index(String searchString)
                     
        {
            var model = from r in _context.SIFRef
                        select r;

            if (!String.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                model = _context.SIFRef.Where(r => r.LastName.ToLower().Contains(searchString) ||
                r.FirstName.ToLower().Contains(searchString)
                );
            }
            return View(await model.ToListAsync());
        }

        // GET: SIFRefs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sIFRef = await _context.SIFRef
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sIFRef == null)
            {
                return NotFound();
            }

            return View(sIFRef);
        }

        // GET: SIFRefs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SIFRefs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,RefNumber,SSN,RefType,RefCategory,RefCategoryType,RefDistrict,RefClub,StreetAddress,ZipCode,City,PhoneNumber1,PhoneNumber2,Email,SeasonRegistred,Status")] SIFRef sIFRef)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sIFRef);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sIFRef);
        }

        // GET: SIFRefs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sIFRef = await _context.SIFRef.FindAsync(id);
            if (sIFRef == null)
            {
                return NotFound();
            }
            return View(sIFRef);
        }

        // POST: SIFRefs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,RefNumber,SSN,RefType,RefCategory,RefCategoryType,RefDistrict,RefClub,StreetAddress,ZipCode,City,PhoneNumber1,PhoneNumber2,Email,SeasonRegistred,Status")] SIFRef sIFRef)
        {
            if (id != sIFRef.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sIFRef);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SIFRefExists(sIFRef.Id))
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
            return View(sIFRef);
        }

        // GET: SIFRefs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sIFRef = await _context.SIFRef
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sIFRef == null)
            {
                return NotFound();
            }

            return View(sIFRef);
        }

        // POST: SIFRefs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sIFRef = await _context.SIFRef.FindAsync(id);
            _context.SIFRef.Remove(sIFRef);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SIFRefExists(int id)
        {
            return _context.SIFRef.Any(e => e.Id == id);
        }
    }
}
