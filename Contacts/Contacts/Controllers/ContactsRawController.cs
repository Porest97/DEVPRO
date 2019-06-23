using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Contacts.Models;

namespace Contacts.Controllers
{
    public class ContactsRawController : Controller
    {
        private readonly ContactsContext _context;

        public ContactsRawController(ContactsContext context)
        {
            _context = context;
        }

        // GET: ContactsRaw
        public async Task<IActionResult> Index(String searchString)
        {
            var model = from m in _context.ContactRaw
                        select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                model = _context.ContactRaw.Where(
                   c => c.FirstName.ToLower().Contains(searchString) ||
                   c.LastName.ToLower().Contains(searchString) ||
                   c.Club.ToLower().Contains(searchString) ||
                   c.AgeCategory.ToLower().Contains(searchString) ||
                   c.District.ToLower().Contains(searchString) ||
                   c.Email.ToLower().Contains(searchString) ||
                   c.PhoneNumber1.ToLower().Contains(searchString) ||
                   c.PhoneNumber2.ToLower().Contains(searchString) ||
                   c.Role.ToLower().Contains(searchString) ||
                   c.Season.ToLower().Contains(searchString) ||
                   c.Sport.ToLower().Contains(searchString) ||
                   c.Ssn.ToLower().Contains(searchString) ||
                   c.Team.ToLower().Contains(searchString)                  

                   );

            }
            return View(await model.ToListAsync());
        }

        // GET: ContactsRaw/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactRaw = await _context.ContactRaw
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactRaw == null)
            {
                return NotFound();
            }

            return View(contactRaw);
        }

        // GET: ContactsRaw/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactsRaw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Club,Team,Role,Sport,District,FirstName,LastName,PhoneNumber1,PhoneNumber2,Email,Ssn,Season,AgeCategory")] ContactRaw contactRaw)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactRaw);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactRaw);
        }

        // GET: ContactsRaw/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactRaw = await _context.ContactRaw.FindAsync(id);
            if (contactRaw == null)
            {
                return NotFound();
            }
            return View(contactRaw);
        }

        // POST: ContactsRaw/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Club,Team,Role,Sport,District,FirstName,LastName,PhoneNumber1,PhoneNumber2,Email,Ssn,Season,AgeCategory")] ContactRaw contactRaw)
        {
            if (id != contactRaw.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactRaw);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactRawExists(contactRaw.Id))
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
            return View(contactRaw);
        }

        // GET: ContactsRaw/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactRaw = await _context.ContactRaw
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactRaw == null)
            {
                return NotFound();
            }

            return View(contactRaw);
        }

        // POST: ContactsRaw/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactRaw = await _context.ContactRaw.FindAsync(id);
            _context.ContactRaw.Remove(contactRaw);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactRawExists(int id)
        {
            return _context.ContactRaw.Any(e => e.Id == id);
        }
    }
}
