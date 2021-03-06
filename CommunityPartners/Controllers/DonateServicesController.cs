﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommunityPartners.Data;
using CommunityPartners.Models;
using CommunityPartners.Contracts;
using System.Security.Claims;
using CommunityPartners.MapViewModels;

namespace CommunityPartners.Controllers
{
    public class DonateServicesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IGeoCodeRequest _geoCodeRequest;

        public DonateServicesController(ApplicationDbContext context, IGeoCodeRequest geoCodeRequest)
        {
            _context = context;
            _geoCodeRequest = geoCodeRequest;
        }
        public async Task<IActionResult> ViewPartnerLocation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var donateService = await _context.DonateServices
                .FirstOrDefaultAsync(m => m.DonateServiceId == id);

            var partner = await _context.Partners
               .Include(p => p.IdentityUser)
               .FirstOrDefaultAsync(m => m.PartnerId == donateService.PartnerId);

            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);

        }
        public async Task <IActionResult> FilterPartnersByRating(MapView mapView, GeoResult geoResult)
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var viewerInDb = _context.Partners.Where(m => m.IdentityUserId == userId).FirstOrDefault();
            var applicationDbContext = _context.Partners.Include(p => p.IdentityUser);
            mapView.partner = viewerInDb;
            var rating = _context.RateServices.Where(r => r.Rating > 1).First();
            var ds = _context.DonateServices.Where(s => s.DonateServiceId == rating.DonateServiceId).First();
            //mapView.donateService = ds;
            var part = _context.Partners.Where(p => p.PartnerId == ds.PartnerId);
            
            //var coords = part.PartnerLat + "," + part.PartnerLong;
            
            //var coor = part.PartnerLat.First();
            //var coorLang = part.PartnerLong;
            
            //var part = _context.Partners.Where(p => p.PartnerId == ds.PartnerId);
            
            return View (await part.ToListAsync());
           
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
        //public async Task<IActionResult> SearchPartners(Partner partner)
        //{
        //    ViewData["PartnerRadiusId"] = new SelectList(_context.partnerRadii, "PartnerRadiusId", "RadiusMiles");
        //    string address = (partner.PartnerAddress.ToString() + ", +" + partner.PartnerAddress.ToString() + ",+" + partner.PartnerState.ToString());
        //    GeoLocation location = await _geoCodeRequest.GetGeoLocation(address);
        //    partner.PartnerLat = location.results[0].geometry.location.lat.ToString();
        //    partner.PartnerLong = location.results[0].geometry.location.lng.ToString();
        //    return View(partner);

        //}
        public async Task<IActionResult> SearchPartners()
        {
            

            return View();
        }



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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: DonateServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DonateService donateService, Partner partner)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var viewerInDb = _context.Partners.Where(m => m.IdentityUserId == userId).FirstOrDefault();
                var applicationDbContext = _context.Partners.Include(p => p.IdentityUser);
                donateService.PartnerId = viewerInDb.PartnerId;
                donateService.PartnerName = viewerInDb.FirstName;
                donateService.PartnerLat = viewerInDb.PartnerLat;
                donateService.PartnerLong = viewerInDb.PartnerLong;
                donateService.PhoneNumber = viewerInDb.PartnerPhone;
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
