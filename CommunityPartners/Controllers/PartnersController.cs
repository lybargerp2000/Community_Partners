﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommunityPartners.Data;
using CommunityPartners.Models;
using System.Security.Claims;
using CommunityPartners.Contracts;
using CommunityPartners.MapViewModels;

namespace CommunityPartners.Controllers
{
    public class PartnersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IGeoCodeRequest _geoCodeRequest;
        public PartnersController(ApplicationDbContext context, IGeoCodeRequest geoCodeRequest)
        {
            _context = context;
            _geoCodeRequest = geoCodeRequest;
        }
        public async Task<IActionResult> SelectState()
        {
            MapView mapView = new MapView();
        
            return View(mapView);
        }
       public async Task<IActionResult> SearchForPartners()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var viewerInDb = _context.Partners.Where(m => m.IdentityUserId == userId).FirstOrDefault();
            var applicationDbContext = _context.Partners.Include(p => p.IdentityUser);
            
            return View(await applicationDbContext.ToListAsync());
           
        }
       

        // GET: Partners
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var viewerInDb =  _context.Partners.Where(m => m.IdentityUserId == userId).FirstOrDefault();
            var applicationDbContext = _context.Partners.Include(p => p.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> ViewLocation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners
                .Include(p => p.IdentityUser)
                .FirstOrDefaultAsync(m => m.PartnerId == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }
        //public async Task<IActionResult> SearchPartners(Partner partner)
        //{
        //    string address = (partner.PartnerAddress.ToString() + ", +" + partner.PartnerAddress.ToString() + ",+" + partner.PartnerState.ToString());
        //    GeoLocation location = await _geoCodeRequest.GetGeoLocation(address);
        //    partner.PartnerLat = location.results[0].geometry.location.lat.ToString();
        //    partner.PartnerLong = location.results[0].geometry.location.lng.ToString();

        //}


        // GET: Partners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners
                .Include(p => p.IdentityUser)
                .FirstOrDefaultAsync(m => m.PartnerId == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        // GET: Partners/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Partners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartnerId,IdentityUserId,FirstName,LastName,HomeLocationId,PartnerPhone,ReOccurringDayRequest,RequestReceiveOrDonate,AmountDonated,Itemdonated,MilesTravelled,PartnerAddress,PartnerCity,PartnerState,PartnerZip,PartnerLong,PartnerLat,PayPalId,TransactionHistory")] Partner partner)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                partner.IdentityUserId = userId;
                string address = (partner.PartnerAddress.ToString() + ", +" + partner.PartnerAddress.ToString() + ",+" + partner.PartnerState.ToString());
                GeoLocation location = await _geoCodeRequest.GetGeoLocation(address);
                partner.PartnerLat = location.results[0].geometry.location.lat.ToString();
                partner.PartnerLong = location.results[0].geometry.location.lng.ToString();
                _context.Add(partner);
                await _context.SaveChangesAsync();
                //_context.Add(partner);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", partner.IdentityUserId);
            return View(partner);
        }

        // GET: Partners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners.FindAsync(id);
            if (partner == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", partner.IdentityUserId);
            return View(partner);
        }

        // POST: Partners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PartnerId,IdentityUserId,FirstName,LastName,HomeLocationId,PartnerPhone,ReOccurringDayRequest,RequestReceiveOrDonate,AmountDonated,Itemdonated,MilesTravelled,PartnerAddress,PartnerCity,PartnerState,PartnerZip,PartnerLong,PartnerLat,PayPalId,TransactionHistory")] Partner partner)
        {
            if (id != partner.PartnerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(partner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartnerExists(partner.PartnerId))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", partner.IdentityUserId);
            return View(partner);
        }

        // GET: Partners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners
                .Include(p => p.IdentityUser)
                .FirstOrDefaultAsync(m => m.PartnerId == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        // POST: Partners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partner = await _context.Partners.FindAsync(id);
            _context.Partners.Remove(partner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartnerExists(int id)
        {
            return _context.Partners.Any(e => e.PartnerId == id);
        }
    }
}
