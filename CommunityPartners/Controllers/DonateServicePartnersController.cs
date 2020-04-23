using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommunityPartners.Data;
using CommunityPartners.Models;
using System.Security.Claims;

namespace CommunityPartners.Controllers
{
    public class DonateServicePartnersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DonateServicePartnersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DonateServicePartners
        public async Task<IActionResult> Index()
        {
            return View(await _context.DonateServicePartnersers.ToListAsync());
        }
        public async Task<IActionResult> ViewPartnerLocation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donateServicePartners = await _context.DonateServicePartnersers
                .FirstOrDefaultAsync(m => m.DonateServicePartnersId == id);
            if (donateServicePartners == null)
            {
                return NotFound();
            }

            return View(donateServicePartners);
        }

        // GET: DonateServicePartners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donateServicePartners = await _context.DonateServicePartnersers
                .FirstOrDefaultAsync(m => m.DonateServicePartnersId == id);
            if (donateServicePartners == null)
            {
                return NotFound();
            }

            return View(donateServicePartners);
        }

        // GET: DonateServicePartners/Create
        public IActionResult Create(Partner partner, DonateServicePartners donateServicePartners)
        {

            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["PartnerId"] = new SelectList(_context.DonateServices, "PartnerId", "DonateserviceId");
            //donateServicePartners.PartnerId = partner.PartnerId;
            return View();
        }

        // POST: DonateServicePartners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DonateServicePartnersId,PartnerId,DonateServiceId,RequestDate,Accepted,PayPalId,RatingHelpfulnessId")] DonateServicePartners donateServicePartners, Partner partner)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                partner.IdentityUserId = userId;
                Partner currentpartner = _context.Partners.Where(v => v.IdentityUserId == userId).FirstOrDefault();
                currentpartner.PartnerId = donateServicePartners.PartnerId;
                var viewerId = currentpartner.PartnerId;
                var testvariable = currentpartner.PartnerId;
                //var id = partner.PartnerId;
                //donateServicePartners.PartnerId = id;
                //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                //partner.IdentityUserId = userId;

                //donateServicePartners.PartnerId = partner.PartnerId;
                //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                //donateServicePartners.IdentityUserId = userId;
                //partner.PartnerId = donateServicePartners.PartnerId;
                //donateServicePartners.PartnerId = partnerId;
                
                _context.Add(donateServicePartners);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", partner.IdentityUserId);
            return View(donateServicePartners);
        }

        // GET: DonateServicePartners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donateServicePartners = await _context.DonateServicePartnersers.FindAsync(id);
            if (donateServicePartners == null)
            {
                return NotFound();
            }
            return View(donateServicePartners);
        }

        // POST: DonateServicePartners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DonateServicePartnersId,PartnerId,DonateServiceId,RequestDate,Accepted,PayPalId,RatingHelpfulnessId")] DonateServicePartners donateServicePartners)
        {
            if (id != donateServicePartners.DonateServicePartnersId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donateServicePartners);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonateServicePartnersExists(donateServicePartners.DonateServicePartnersId))
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
            return View(donateServicePartners);
        }

        // GET: DonateServicePartners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donateServicePartners = await _context.DonateServicePartnersers
                .FirstOrDefaultAsync(m => m.DonateServicePartnersId == id);
            if (donateServicePartners == null)
            {
                return NotFound();
            }

            return View(donateServicePartners);
        }

        // POST: DonateServicePartners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donateServicePartners = await _context.DonateServicePartnersers.FindAsync(id);
            _context.DonateServicePartnersers.Remove(donateServicePartners);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonateServicePartnersExists(int id)
        {
            return _context.DonateServicePartnersers.Any(e => e.DonateServicePartnersId == id);
        }
    }
}
