using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HStats.Models;

namespace HStats.Controllers
{
    public class PeopleController : Controller
    {
        private readonly HStatsContext _context;

        public PeopleController(HStatsContext context)
        {
            _context = context;
        }

        // GET: People
        public async Task<IActionResult> Index()
        {
            var hStatsContext = _context.Person.Include(p => p.Club).Include(p => p.Club1).Include(p => p.CoachStatus).Include(p => p.PlayerStatus).Include(p => p.RefereeStatus).Include(p => p.StaffStatus);
            return View(await hStatsContext.ToListAsync());
        }

        // GET: People/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .Include(p => p.Club)
                .Include(p => p.Club1)
                .Include(p => p.CoachStatus)
                .Include(p => p.PlayerStatus)
                .Include(p => p.RefereeStatus)
                .Include(p => p.StaffStatus)
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
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName");
            ViewData["ClubId1"] = new SelectList(_context.Set<Club>(), "Id", "ClubName");
            ViewData["CoachStatusId"] = new SelectList(_context.Set<CoachStatus>(), "Id", "SCStatus");
            ViewData["PlayerStatusId"] = new SelectList(_context.Set<PlayerStatus>(), "Id", "PStatus");
            ViewData["RefereeStatusId"] = new SelectList(_context.Set<RefereeStatus>(), "Id", "RStatus");
            ViewData["StaffStatusId"] = new SelectList(_context.Set<StaffStatus>(), "Id", "SStatus");
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,StreetAddress,ZipCode,County,Country,Ssn,PhoneNumber,Email,ClubId,ClubId1,RefereeStatusId,CoachStatusId,PlayerStatusId,StaffStatusId,PhoneNumber1")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", person.ClubId);
            ViewData["ClubId1"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", person.ClubId1);
            ViewData["CoachStatusId"] = new SelectList(_context.Set<CoachStatus>(), "Id", "SCStatus", person.CoachStatusId);
            ViewData["PlayerStatusId"] = new SelectList(_context.Set<PlayerStatus>(), "Id", "PStatus", person.PlayerStatusId);
            ViewData["RefereeStatusId"] = new SelectList(_context.Set<RefereeStatus>(), "Id", "RStatus", person.RefereeStatusId);
            ViewData["StaffStatusId"] = new SelectList(_context.Set<StaffStatus>(), "Id", "SStatus", person.StaffStatusId);
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
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", person.ClubId);
            ViewData["ClubId1"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", person.ClubId1);
            ViewData["CoachStatusId"] = new SelectList(_context.Set<CoachStatus>(), "Id", "SCStatus", person.CoachStatusId);
            ViewData["PlayerStatusId"] = new SelectList(_context.Set<PlayerStatus>(), "Id", "PStatus", person.PlayerStatusId);
            ViewData["RefereeStatusId"] = new SelectList(_context.Set<RefereeStatus>(), "Id", "RStatus", person.RefereeStatusId);
            ViewData["StaffStatusId"] = new SelectList(_context.Set<StaffStatus>(), "Id", "SStatus", person.StaffStatusId);
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,StreetAddress,ZipCode,County,Country,Ssn,PhoneNumber,Email,ClubId,ClubId1,RefereeStatusId,CoachStatusId,PlayerStatusId,StaffStatusId,PhoneNumber1")] Person person)
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
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", person.ClubId);
            ViewData["ClubId1"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", person.ClubId1);
            ViewData["CoachStatusId"] = new SelectList(_context.Set<CoachStatus>(), "Id", "SCStatus", person.CoachStatusId);
            ViewData["PlayerStatusId"] = new SelectList(_context.Set<PlayerStatus>(), "Id", "PStatus", person.PlayerStatusId);
            ViewData["RefereeStatusId"] = new SelectList(_context.Set<RefereeStatus>(), "Id", "RStatus", person.RefereeStatusId);
            ViewData["StaffStatusId"] = new SelectList(_context.Set<StaffStatus>(), "Id", "SStatus", person.StaffStatusId);
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
                .Include(p => p.Club)
                .Include(p => p.Club1)
                .Include(p => p.CoachStatus)
                .Include(p => p.PlayerStatus)
                .Include(p => p.RefereeStatus)
                .Include(p => p.StaffStatus)
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
