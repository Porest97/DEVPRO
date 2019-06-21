﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetelloBusinessSolution.Data;
using NetelloBusinessSolution.Models.TestModels;

namespace NetelloBusinessSolution.Controllers
{
    public class PROWorkReportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PROWorkReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PROWorkReports
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PROWorkReport.Include(p => p.AssignedPerson).Include(p => p.Company).Include(p => p.OrderedBy).Include(p => p.PurchaseOrder);
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: WorkReports HttpPost !
        [HttpPost]
        public IActionResult Index(PROWorkReport pROworkReport)
        {
            var applicationDbContext = _context.PROWorkReport.Include(p => p.AssignedPerson).Include(p => p.Company).Include(p => p.OrderedBy).Include(p => p.PurchaseOrder);
            pROworkReport.TotalPayment = pROworkReport.TimeWorked * pROworkReport.PaymentPerHour;
            return View(pROworkReport);
        }

        // GET: PROWorkReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pROWorkReport = await _context.PROWorkReport
                .Include(p => p.AssignedPerson)
                .Include(p => p.Company)
                .Include(p => p.OrderedBy)
                .Include(p => p.PurchaseOrder)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pROWorkReport == null)
            {
                return NotFound();
            }

            return View(pROWorkReport);
        }

        // GET: PROWorkReports/Create
        public IActionResult Create()
        {
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "CName");
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "CompanyName");
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "CName");
            ViewData["PurchaseOrderId"] = new SelectList(_context.PurchaseOrder, "Id", "POName");
            return View();
        }

        // POST: PROWorkReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompanyId,PersonId,PersonId1,WorkStarted,WorkEnded,TimeWorked,PaymentPerHour,TotalPayment,PurchaseOrderId,WorkNote")] PROWorkReport pROWorkReport)
        {
            if (ModelState.IsValid)
            {
                var applicationDbContext = _context.PROWorkReport.Include(p => p.AssignedPerson).Include(p => p.Company).Include(p => p.OrderedBy).Include(p => p.PurchaseOrder);
                pROWorkReport.TotalPayment = pROWorkReport.TimeWorked * pROWorkReport.PaymentPerHour;
                _context.Add(pROWorkReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "CName", pROWorkReport.PersonId);
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "CompanyName", pROWorkReport.CompanyId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "CName", pROWorkReport.PersonId1);
            ViewData["PurchaseOrderId"] = new SelectList(_context.PurchaseOrder, "Id", "POName", pROWorkReport.PurchaseOrderId);
            return View(pROWorkReport);
        }

        // GET: PROWorkReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pROWorkReport = await _context.PROWorkReport.FindAsync(id);
            if (pROWorkReport == null)
            {
                return NotFound();
            }
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "CName", pROWorkReport.PersonId);
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "CompanyName", pROWorkReport.CompanyId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "CName", pROWorkReport.PersonId1);
            ViewData["PurchaseOrderId"] = new SelectList(_context.PurchaseOrder, "Id", "POName", pROWorkReport.PurchaseOrderId);
            return View(pROWorkReport);
        }

        // POST: PROWorkReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyId,PersonId,PersonId1,WorkStarted,WorkEnded,TimeWorked,PaymentPerHour,TotalPayment,PurchaseOrderId,WorkNote")] PROWorkReport pROWorkReport)
        {
            if (id != pROWorkReport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var applicationDbContext = _context.PROWorkReport.Include(p => p.AssignedPerson).Include(p => p.Company).Include(p => p.OrderedBy).Include(p => p.PurchaseOrder);
                    pROWorkReport.TotalPayment = pROWorkReport.TimeWorked * pROWorkReport.PaymentPerHour;

                    _context.Update(pROWorkReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PROWorkReportExists(pROWorkReport.Id))
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
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "CName", pROWorkReport.PersonId);
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "CompanyName", pROWorkReport.CompanyId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "CName", pROWorkReport.PersonId1);
            ViewData["PurchaseOrderId"] = new SelectList(_context.PurchaseOrder, "Id", "POName", pROWorkReport.PurchaseOrderId);
            return View(pROWorkReport);
        }

        // GET: PROWorkReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pROWorkReport = await _context.PROWorkReport
                .Include(p => p.AssignedPerson)
                .Include(p => p.Company)
                .Include(p => p.OrderedBy)
                .Include(p => p.PurchaseOrder)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pROWorkReport == null)
            {
                return NotFound();
            }

            return View(pROWorkReport);
        }

        // POST: PROWorkReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pROWorkReport = await _context.PROWorkReport.FindAsync(id);
            _context.PROWorkReport.Remove(pROWorkReport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PROWorkReportExists(int id)
        {
            return _context.PROWorkReport.Any(e => e.Id == id);
        }
    }
}
