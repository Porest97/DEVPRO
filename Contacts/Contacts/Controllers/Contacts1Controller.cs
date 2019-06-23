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
    public class Contacts1Controller : Controller
    {
        private readonly ContactsContext _context;

        public Contacts1Controller(ContactsContext context)
        {
            _context = context;
        }

        // GET: Contacts1
        public async Task<IActionResult> Index(String searchString)
        {
            // Query for retrieving all Contacts
            var contacts = from c in _context.Contact
                           select c;
            // Query for retrieving referees that contain the searchstring
            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = _context.Contact
                    .Where(c => c.Email.ToLower().Contains(searchString.ToLower()) ||
                    c.FullName.ToLower().Contains(searchString.ToLower()) ||
                    c.District.DistrictName.ToLower().Contains(searchString.ToLower()) ||
                    c.Club.ClubName.ToLower().Contains(searchString.ToLower()) ||
                    c.PhoneNumbers.ToLower().Contains(searchString.ToLower()) ||
                    c.Role.RoleName.ToLower().Contains(searchString.ToLower()) ||
                    c.Season.SeasonName.ToLower().Contains(searchString.ToLower())
                    );

            }
            var contactsContext = _context.Contact.Include(c => c.AgeCategory).Include(c => c.Club).Include(c => c.District).Include(c => c.Role).Include(c => c.Season).Include(c => c.Sport).Include(c => c.Team);
            return View(await contactsContext.ToListAsync());
        }

        // GET: Contacts1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.AgeCategory)
                .Include(c => c.Club)
                .Include(c => c.District)
                .Include(c => c.Role)
                .Include(c => c.Season)
                .Include(c => c.Sport)
                .Include(c => c.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // GET: Contacts1/Create
        public IActionResult Create()
        {
            ViewData["AgeCategoryId"] = new SelectList(_context.AgeCategory, "Id", "AgeCategoryName");
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["DistrictId"] = new SelectList(_context.District, "Id", "DistrictName");
            ViewData["RoleId"] = new SelectList(_context.Role, "Id", "RoleName");
            ViewData["SeasonId"] = new SelectList(_context.Season, "Id", "SeasonName");
            ViewData["SportId"] = new SelectList(_context.Sport, "Id", "SportName");
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName");
            return View();
        }

        // POST: Contacts1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClubId,TeamId,RoleId,SportId,DistrictId,SeasonId,AgeCategoryId,FirstName,LastName,PhoneNumber1,PhoneNumber2,Email,Ssn")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgeCategoryId"] = new SelectList(_context.Set<AgeCategory>(), "Id", "AgeCategoryName", contact.AgeCategoryId);
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", contact.ClubId);
            ViewData["DistrictId"] = new SelectList(_context.Set<District>(), "Id", "DistrictName", contact.DistrictId);
            ViewData["RoleId"] = new SelectList(_context.Set<Role>(), "Id", "RoleName", contact.RoleId);
            ViewData["SeasonId"] = new SelectList(_context.Set<Season>(), "Id", "SeasonName", contact.SeasonId);
            ViewData["SportId"] = new SelectList(_context.Set<Sport>(), "Id", "SportName", contact.SportId);
            ViewData["TeamId"] = new SelectList(_context.Set<Team>(), "Id", "TeamName", contact.TeamId);
            return View(contact);
        }

        // GET: Contacts1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            ViewData["AgeCategoryId"] = new SelectList(_context.Set<AgeCategory>(), "Id", "AgeCategoryName", contact.AgeCategoryId);
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", contact.ClubId);
            ViewData["DistrictId"] = new SelectList(_context.Set<District>(), "Id", "DistrictName", contact.DistrictId);
            ViewData["RoleId"] = new SelectList(_context.Set<Role>(), "Id", "RoleName", contact.RoleId);
            ViewData["SeasonId"] = new SelectList(_context.Set<Season>(), "Id", "SeasonName", contact.SeasonId);
            ViewData["SportId"] = new SelectList(_context.Set<Sport>(), "Id", "SportName", contact.SportId);
            ViewData["TeamId"] = new SelectList(_context.Set<Team>(), "Id", "TeamName", contact.TeamId);
            return View(contact);
        }

        // POST: Contacts1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClubId,TeamId,RoleId,SportId,DistrictId,SeasonId,AgeCategoryId,FirstName,LastName,PhoneNumber1,PhoneNumber2,Email,Ssn")] Contact contact)
        {
            if (id != contact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.Id))
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
            ViewData["AgeCategoryId"] = new SelectList(_context.Set<AgeCategory>(), "Id", "AgeCategoryName", contact.AgeCategoryId);
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", contact.ClubId);
            ViewData["DistrictId"] = new SelectList(_context.Set<District>(), "Id", "DistrictName", contact.DistrictId);
            ViewData["RoleId"] = new SelectList(_context.Set<Role>(), "Id", "RoleName", contact.RoleId);
            ViewData["SeasonId"] = new SelectList(_context.Set<Season>(), "Id", "SeasonName", contact.SeasonId);
            ViewData["SportId"] = new SelectList(_context.Set<Sport>(), "Id", "SportName", contact.SportId);
            ViewData["TeamId"] = new SelectList(_context.Set<Team>(), "Id", "TeamName", contact.TeamId);
            return View(contact);
        }

        // GET: Contacts1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.AgeCategory)
                .Include(c => c.Club)
                .Include(c => c.District)
                .Include(c => c.Role)
                .Include(c => c.Season)
                .Include(c => c.Sport)
                .Include(c => c.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Contacts1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contact.FindAsync(id);
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Season20182019()
        {
            var contactsContext = _context.Contact.Include(c => c.AgeCategory).Include(c => c.Club).Include(c => c.District).Include(c => c.Role).Include(c => c.Season).Include(c => c.Sport).Include(c => c.Team);
            return View(await contactsContext.ToListAsync());
        }


        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.Id == id);
        }
    }
}
