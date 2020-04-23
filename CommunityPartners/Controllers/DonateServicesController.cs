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
    public class DonateServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DonateServicesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> AcceptService(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donateService = await _context.DonateServices
                .FirstOrDefaultAsync(m => m.DonateServiceId == id);
            if (donateService == null)
            {
                return NotFound();
            }

            return View(donateService);
        }
        public IActionResult ViewWhoAccepted()
        {
            return View();

        }
        //public Task AcceptSericeToFinal()
        //{

        //}


        // GET: DonateServices
        public async Task<IActionResult> Index()
        {
            return View(await _context.DonateServices.ToListAsync());
        }

        // GET: DonateServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donateService = await _context.DonateServices
                .FirstOrDefaultAsync(m => m.DonateServiceId == id);
            if (donateService == null)
            {
                return NotFound();
            }

            return View(donateService);
        }

        // GET: DonateServices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DonateServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DonateServiceId,PartnerId,Date,DonationRadiusMiles,Zipcode,Description")] DonateService donateService)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donateService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(donateService);
        }

        // GET: DonateServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donateService = await _context.DonateServices.FindAsync(id);
            if (donateService == null)
            {
                return NotFound();
            }
            return View(donateService);
        }

        // POST: DonateServices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DonateServiceId,PartnerId,Date,DonationRadiusMiles,Zipcode,Description")] DonateService donateService)
        {
            if (id != donateService.DonateServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donateService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonateServiceExists(donateService.DonateServiceId))
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
            return View(donateService);
        }

        // GET: DonateServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donateService = await _context.DonateServices
                .FirstOrDefaultAsync(m => m.DonateServiceId == id);
            if (donateService == null)
            {
                return NotFound();
            }

            return View(donateService);
        }

        // POST: DonateServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donateService = await _context.DonateServices.FindAsync(id);
            _context.DonateServices.Remove(donateService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonateServiceExists(int id)
        {
            return _context.DonateServices.Any(e => e.DonateServiceId == id);
        }
    }
}
