using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommunityPartners.Data;
using CommunityPartners.Models;

namespace CommunityPartners.Controllers
{
    public class RateServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RateServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RateServices
        public async Task<IActionResult> Index()
        {
            return View(await _context.RateServices.ToListAsync());
        }

        // GET: RateServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rateService = await _context.RateServices
                .FirstOrDefaultAsync(m => m.RateServiceId == id);
            if (rateService == null)
            {
                return NotFound();
            }

            return View(rateService);
        }

        // GET: RateServices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RateServices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RateServiceId,DonateServiceId,Date,Rating,Description")] RateService rateService)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rateService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rateService);
        }

        // GET: RateServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rateService = await _context.RateServices.FindAsync(id);
            if (rateService == null)
            {
                return NotFound();
            }
            return View(rateService);
        }

        // POST: RateServices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RateServiceId,DonateServiceId,Date,Rating,Description")] RateService rateService)
        {
            if (id != rateService.RateServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rateService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RateServiceExists(rateService.RateServiceId))
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
            return View(rateService);
        }

        // GET: RateServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rateService = await _context.RateServices
                .FirstOrDefaultAsync(m => m.RateServiceId == id);
            if (rateService == null)
            {
                return NotFound();
            }

            return View(rateService);
        }

        // POST: RateServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rateService = await _context.RateServices.FindAsync(id);
            _context.RateServices.Remove(rateService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RateServiceExists(int id)
        {
            return _context.RateServices.Any(e => e.RateServiceId == id);
        }
    }
}
