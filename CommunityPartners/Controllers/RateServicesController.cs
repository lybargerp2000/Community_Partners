using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommunityPartners.Data;
using CommunityPartners.Models;
using CommunityPartners.MapViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Formatters;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;

namespace CommunityPartners.Controllers
{
    public class RateServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RateServicesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult SelectRating()
        {

            return View();
        }
        [HttpPost]
        public async Task <IActionResult> SelectRating(RateService rateService)
        {

            var valuee = 5;
            var rating = _context.RateServices.Where(r => r.Rating > valuee).First();

            //return IndexForRating(input, rateService);
            return RedirectToAction(nameof(Index));

        }
        //public IActionResult IndexForRating()
        //{
        //    //var rating = _context.RateServices.Where(r => r.Rating > input).First();
        //    //var superrating = _context.RateServices.Where(s => s.RateServiceId == rating.RateServiceId).ToListAsync();
        //    //return View(superrating);
        //    return View();
        //}

        public IActionResult IndexForRating(int input, RateService rateService)
        {
            var rating = _context.RateServices.Where(r => r.Rating > input).First();
            var superrating = _context.RateServices.Where(s => s.RateServiceId == rating.RateServiceId).ToListAsync();
            //return View(rating);
            //rateService.Rating = rating.Rating;
            //return Index(superrating);
            //return Index(rating);
            return View(_context.RateServices.ToListAsync());
        }

        public async Task<IActionResult> FilterPartnersByRating(int input)
        {
            
                ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var viewerInDb = _context.Partners.Where(m => m.IdentityUserId == userId).FirstOrDefault();
                var applicationDbContext = _context.Partners.Include(p => p.IdentityUser);
                //mapView.partner = viewerInDb;
                
                var rating = _context.RateServices.Where(r => r.Rating > input).First();
                var part = _context.Partners.Where(p => p.PartnerId == rating.PartnerId);
                

                return View(await part.ToListAsync());
            
        }
        // GET: RateServices
        public async Task<IActionResult> Index()
        {
            var input = View();
            var applicationDbContext = _context.RateServices;
            ViewData["Rating"] = new SelectList(_context.RateServices);
            
            //return View(admin);
            return View(await applicationDbContext.ToListAsync());
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
        public async Task<IActionResult> Create([Bind("RateServiceId,DonateServiceId,Date,Rating,Description")] RateService rateService, int id, Partner partner)
        {
            if (ModelState.IsValid)
            {
                var donateService = _context.DonateServices.FindAsync(id).Result;
                var partnerId = _context.Partners.Where(p => p.PartnerId == donateService.PartnerId).FirstOrDefault();
               
                
                rateService.DonateServiceId = id;
                rateService.PartnerId = partnerId.PartnerId;
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
