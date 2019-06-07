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
    public class PeopleController : Controller
    {
        private readonly PROContactsContext _context;

        public PeopleController(PROContactsContext context)
        {
            _context = context;
        }

        // GET: People
        public async Task<IActionResult> Index()
        {
            var pROContactsContext = _context.Person.Include(p => p.AgeGroup).Include(p => p.Club).Include(p => p.District).Include(p => p.Season).Include(p => p.Sport).Include(p => p.Team);
            return View(await pROContactsContext.ToListAsync());
        }

        // GET: People/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .Include(p => p.AgeGroup)
                .Include(p => p.Club)
                .Include(p => p.District)
                .Include(p => p.Season)
                .Include(p => p.Sport)
                .Include(p => p.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // GET: People/Create
        public IActionResult Create()
        {
            ViewData["AgeGroupId"] = new SelectList(_context.AgeGroup, "Id", "AgeGroupName");
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["DistrictId"] = new SelectList(_context.District, "Id", "DistrictName");
            ViewData["SeasonId"] = new SelectList(_context.Set<Season>(), "Id", "SeasonName");
            ViewData["SportId"] = new SelectList(_context.Sport, "Id", "SportName");
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName");
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,StreetAddress,ZipCode,County,Country,Ssn,PhoneNumber1,PhoneNumber2,Email,ClubId,SportId,DistrictId,AgeGroupId,TeamId,SeasonId")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgeGroupId"] = new SelectList(_context.AgeGroup, "Id", "AgeGroupName", person.AgeGroupId);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", person.ClubId);
            ViewData["DistrictId"] = new SelectList(_context.District, "Id", "DistrictName", person.DistrictId);
            ViewData["SeasonId"] = new SelectList(_context.Set<Season>(), "Id", "SeasonName", person.SeasonId);
            ViewData["SportId"] = new SelectList(_context.Sport, "Id", "SportName", person.SportId);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", person.TeamId);
            return View(person);
        }

        // GET: People/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            ViewData["AgeGroupId"] = new SelectList(_context.AgeGroup, "Id", "AgeGroupName", person.AgeGroupId);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", person.ClubId);
            ViewData["DistrictId"] = new SelectList(_context.District, "Id", "DistrictName", person.DistrictId);
            ViewData["SeasonId"] = new SelectList(_context.Set<Season>(), "Id", "SeasonName", person.SeasonId);
            ViewData["SportId"] = new SelectList(_context.Sport, "Id", "SportName", person.SportId);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", person.TeamId);
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,StreetAddress,ZipCode,County,Country,Ssn,PhoneNumber1,PhoneNumber2,Email,ClubId,SportId,DistrictId,AgeGroupId,TeamId,SeasonId")] Person person)
        {
            if (id != person.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.Id))
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
            ViewData["AgeGroupId"] = new SelectList(_context.AgeGroup, "Id", "AgeGroupName", person.AgeGroupId);
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", person.ClubId);
            ViewData["DistrictId"] = new SelectList(_context.District, "Id", "DistrictName", person.DistrictId);
            ViewData["SeasonId"] = new SelectList(_context.Set<Season>(), "Id", "SeasonName", person.SeasonId);
            ViewData["SportId"] = new SelectList(_context.Sport, "Id", "SportName", person.SportId);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", person.TeamId);
            return View(person);
        }

        // GET: People/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .Include(p => p.AgeGroup)
                .Include(p => p.Club)
                .Include(p => p.District)
                .Include(p => p.Season)
                .Include(p => p.Sport)
                .Include(p => p.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.Person.FindAsync(id);
            _context.Person.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.Id == id);
        }
    }
}
