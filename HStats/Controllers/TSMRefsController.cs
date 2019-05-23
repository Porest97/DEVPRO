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
    public class TSMRefsController : Controller
    {
        private readonly HStatsContext _context;

        public TSMRefsController(HStatsContext context)
        {
            _context = context;
        }

        // GET: TSMRefs
        public async Task<IActionResult> Index()
        {
            var hStatsContext = _context.TSMRef.Include(t => t.Club).Include(t => t.RefereeCategory).Include(t => t.RefereeCategoryType).Include(t => t.RefereeDistrict).Include(t => t.RefereeType);
            return View(await hStatsContext.ToListAsync());
        }

        // GET: TSMRefs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMRef = await _context.TSMRef
                .Include(t => t.Club)
                .Include(t => t.RefereeCategory)
                .Include(t => t.RefereeCategoryType)
                .Include(t => t.RefereeDistrict)
                .Include(t => t.RefereeType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tSMRef == null)
            {
                return NotFound();
            }

            return View(tSMRef);
        }

        // GET: TSMRefs/Create
        public IActionResult Create()
        {
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName");
            ViewData["RefereeCategoryId"] = new SelectList(_context.Set<RefereeCategory>(), "Id", "RefereeCategoryName");
            ViewData["RefereeCategoryTypeId"] = new SelectList(_context.Set<RefereeCategoryType>(), "Id", "RefereeCategoryTypeName");
            ViewData["RefereeDistrictId"] = new SelectList(_context.Set<RefereeDistrict>(), "Id", "RefereeDistrictName");
            ViewData["RefereeTypeId"] = new SelectList(_context.Set<RefereeType>(), "Id", "RefereeTypeName");
            return View();
        }

        // POST: TSMRefs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,RefNumber,Ssn,RefereeTypeId,RefereeCategoryId,RefereeCategoryTypeId,RefereeDistrictId,ClubId,StreetAddress,ZipCode,County,Country,PhoneNumber1,PhoneNumber2,Email")] TSMRef tSMRef)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tSMRef);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", tSMRef.ClubId);
            ViewData["RefereeCategoryId"] = new SelectList(_context.Set<RefereeCategory>(), "Id", "RefereeCategoryName", tSMRef.RefereeCategoryId);
            ViewData["RefereeCategoryTypeId"] = new SelectList(_context.Set<RefereeCategoryType>(), "Id", "RefereeCategoryTypeName", tSMRef.RefereeCategoryTypeId);
            ViewData["RefereeDistrictId"] = new SelectList(_context.Set<RefereeDistrict>(), "Id", "RefereeDistrictName", tSMRef.RefereeDistrictId);
            ViewData["RefereeTypeId"] = new SelectList(_context.Set<RefereeType>(), "Id", "RefereeTypeName", tSMRef.RefereeTypeId);
            return View(tSMRef);
        }

        // GET: TSMRefs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMRef = await _context.TSMRef.FindAsync(id);
            if (tSMRef == null)
            {
                return NotFound();
            }
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", tSMRef.ClubId);
            ViewData["RefereeCategoryId"] = new SelectList(_context.Set<RefereeCategory>(), "Id", "RefereeCategoryName", tSMRef.RefereeCategoryId);
            ViewData["RefereeCategoryTypeId"] = new SelectList(_context.Set<RefereeCategoryType>(), "Id", "RefereeCategoryTypeName", tSMRef.RefereeCategoryTypeId);
            ViewData["RefereeDistrictId"] = new SelectList(_context.Set<RefereeDistrict>(), "Id", "RefereeDistrictName", tSMRef.RefereeDistrictId);
            ViewData["RefereeTypeId"] = new SelectList(_context.Set<RefereeType>(), "Id", "RefereeTypeName", tSMRef.RefereeTypeId);
            return View(tSMRef);
        }

        // POST: TSMRefs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,RefNumber,Ssn,RefereeTypeId,RefereeCategoryId,RefereeCategoryTypeId,RefereeDistrictId,ClubId,StreetAddress,ZipCode,County,Country,PhoneNumber1,PhoneNumber2,Email")] TSMRef tSMRef)
        {
            if (id != tSMRef.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tSMRef);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TSMRefExists(tSMRef.Id))
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
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", tSMRef.ClubId);
            ViewData["RefereeCategoryId"] = new SelectList(_context.Set<RefereeCategory>(), "Id", "RefereeCategoryName", tSMRef.RefereeCategoryId);
            ViewData["RefereeCategoryTypeId"] = new SelectList(_context.Set<RefereeCategoryType>(), "Id", "RefereeCategoryTypeName", tSMRef.RefereeCategoryTypeId);
            ViewData["RefereeDistrictId"] = new SelectList(_context.Set<RefereeDistrict>(), "Id", "RefereeDistrictName", tSMRef.RefereeDistrictId);
            ViewData["RefereeTypeId"] = new SelectList(_context.Set<RefereeType>(), "Id", "RefereeTypeName", tSMRef.RefereeTypeId);
            return View(tSMRef);
        }

        // GET: TSMRefs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMRef = await _context.TSMRef
                .Include(t => t.Club)
                .Include(t => t.RefereeCategory)
                .Include(t => t.RefereeCategoryType)
                .Include(t => t.RefereeDistrict)
                .Include(t => t.RefereeType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tSMRef == null)
            {
                return NotFound();
            }

            return View(tSMRef);
        }

        // POST: TSMRefs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tSMRef = await _context.TSMRef.FindAsync(id);
            _context.TSMRef.Remove(tSMRef);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TSMRefExists(int id)
        {
            return _context.TSMRef.Any(e => e.Id == id);
        }
    }
}
