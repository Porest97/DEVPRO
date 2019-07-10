using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Contacts.Models;
using Contacts.Models.Schedule;

namespace Contacts.Controllers.ScheduleControllers
{
    public class SchedulesController : Controller
    {
        private readonly ContactsContext _context;

        public SchedulesController(ContactsContext context)
        {
            _context = context;
        }

        // GET: Schedules
        public async Task<IActionResult> Index()
        {
            var contactsContext = _context.Schedule.Include(s => s.Person);
            return View(await contactsContext.ToListAsync());
        }

        // GET: Schedules
        [HttpPost]
        public IActionResult Index(Schedule schedule)
        {
            var contactsContext = _context.Schedule.Include(s => s.Person);
            schedule.TotalHours = schedule.HoursMonday 
                + schedule.HoursTuesday 
                + schedule.HoursWednesday 
                + schedule.HoursThursday 
                + schedule.HoursFriday 
                + schedule.HoursSaturday 
                + schedule.HoursSaturday;
            return View(schedule);
        }

        // GET: Schedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .Include(s => s.Person)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // GET: Schedules/Create
        public IActionResult Create()
        {
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName");
            return View();
        }

        // POST: Schedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,WeekNumber,PersonId,Monday,HoursMonday,Tuesday,HoursTuesday,Wednesday,HoursWednesday,Thursday,HoursThursday,Friday,HoursFriday,Saturday,HoursSaturday,Sunday,HoursSunday,TotalHours")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                var contactsContext = _context.Schedule.Include(s => s.Person);
                schedule.TotalHours = schedule.HoursMonday 
                    + schedule.HoursTuesday 
                    + schedule.HoursWednesday 
                    + schedule.HoursThursday 
                    + schedule.HoursFriday 
                    + schedule.HoursSaturday 
                    + schedule.HoursSaturday;
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", schedule.PersonId);
            return View(schedule);
        }

        // GET: Schedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", schedule.PersonId);
            return View(schedule);
        }

        // POST: Schedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WeekNumber,PersonId,Monday,HoursMonday,Tuesday,HoursTuesday,Wednesday,HoursWednesday,Thursday,HoursThursday,Friday,HoursFriday,Saturday,HoursSaturday,Sunday,HoursSunday,TotalHours")] Schedule schedule)
        {
            if (id != schedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var contactsContext = _context.Schedule.Include(s => s.Person);
                    schedule.TotalHours = schedule.HoursMonday 
                        + schedule.HoursTuesday 
                        + schedule.HoursWednesday 
                        + schedule.HoursThursday 
                        + schedule.HoursFriday 
                        + schedule.HoursSaturday 
                        + schedule.HoursSaturday;
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.Id))
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
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", schedule.PersonId);
            return View(schedule);
        }

        // GET: Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .Include(s => s.Person)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schedule = await _context.Schedule.FindAsync(id);
            _context.Schedule.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id)
        {
            return _context.Schedule.Any(e => e.Id == id);
        }
    }
}
