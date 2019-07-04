﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Contacts.Models;
using Contacts.Models.ViewModels;

namespace Contacts.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactsContext _context;

        public ContactsController(ContactsContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> ViewDB()
        {
            var contactsContext = _context.Contact.Include(c => c.AgeCategory).Include(c => c.Club).Include(c => c.District).Include(c => c.Role).Include(c => c.Season).Include(c => c.Sport).Include(c => c.Team);
            return View(await contactsContext.ToListAsync());
        }
        // GET: Contacts
        public async Task<IActionResult> Index()
        {                     
            var contactsContext = _context.Contact.Include(c => c.AgeCategory).Include(c => c.Club).Include(c => c.District).Include(c => c.Role).Include(c => c.Season).Include(c => c.Sport).Include(c => c.Team);
            return View(await contactsContext.ToListAsync());
        }

        // GET: WorkReports to ListContacts
        public IActionResult ListContacts()
        {

            var contacts = _context.Contact.Select(c => c.Id);

            var contactsViewModel = new ContactsViewModel()
            {
                Contacts = _context.Contact.Where(c => c.Id != 0)
                .Include(c => c.AgeCategory)
                .Include(c => c.Club)
                .Include(c => c.District)
                .Include(c => c.Role)
                .Include(c => c.Season)
                .Include(c => c.Sport)
                .Include(c => c.Team).ToList(),
            };

            return View(contactsViewModel);
        }

        // GET: Contacts/Details/5
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

        // GET: Contacts/Create
        public IActionResult Create()
        {
            ViewData["AgeCategoryId"] = new SelectList(_context.Set<AgeCategory>(), "Id", "AgeCategoryName");
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName");
            ViewData["DistrictId"] = new SelectList(_context.Set<District>(), "Id", "DistrictName");
            ViewData["RoleId"] = new SelectList(_context.Set<Role>(), "Id", "RoleName");
            ViewData["SeasonId"] = new SelectList(_context.Set<Season>(), "Id", "SeasonName");
            ViewData["SportId"] = new SelectList(_context.Set<Sport>(), "Id", "SportName");
            ViewData["TeamId"] = new SelectList(_context.Set<Team>(), "Id", "TeamName");
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AgeCategoryId,ClubId,TeamId,RoleId,SeasonId,SportId,DistrictId,FirstName,LastName,PhoneNumber1,PhoneNumber2,Email,Ssn")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ViewDB));
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
        /// <summary>
        /// FastCreate
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: Contacts/Create
        public IActionResult FastCreate()
        {
            ViewData["AgeCategoryId"] = new SelectList(_context.Set<AgeCategory>(), "Id", "AgeCategoryName");
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName");
            ViewData["DistrictId"] = new SelectList(_context.Set<District>(), "Id", "DistrictName");
            ViewData["RoleId"] = new SelectList(_context.Set<Role>(), "Id", "RoleName");
            ViewData["SeasonId"] = new SelectList(_context.Set<Season>(), "Id", "SeasonName");
            ViewData["SportId"] = new SelectList(_context.Set<Sport>(), "Id", "SportName");
            ViewData["TeamId"] = new SelectList(_context.Set<Team>(), "Id", "TeamName");
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FastCreate([Bind("Id,AgeCategoryId,ClubId,TeamId,RoleId,SeasonId,SportId,DistrictId,FirstName,LastName,PhoneNumber1,PhoneNumber2,Email,Ssn")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(FastCreate));
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

        // GET: Contacts/Edit/5
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

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AgeCategoryId,ClubId,TeamId,RoleId,SeasonId,SportId,DistrictId,FirstName,LastName,PhoneNumber1,PhoneNumber2,Email,Ssn")] Contact contact)
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
                return RedirectToAction(nameof(ViewDB));
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

        // GET: Contacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.Club)
                .Include(c => c.District)
                .Include(c => c.Role)
                .Include(c => c.Sport)
                .Include(c => c.Team)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contact.FindAsync(id);
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.Id == id);
        }
    }
}
