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
using System.Reflection.Metadata.Ecma335;

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
            //var partner = _context.Partners.Include(p => p.PartnerId == donateServicePartners.PartnerId);
            //partner.PartnerId = donateServicePartners.PartnerId;
            var partner = await _context.Partners
               .Include(p => p.IdentityUser)
               .FirstOrDefaultAsync(m => m.PartnerId == donateServicePartners.PartnerId);

            //var partner = await _context.Partners
            //    .Include(p => p.IdentityUser)
            //    .FirstOrDefaultAsync(m => m.PartnerId == id);


            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
            //var donateServicePartners = await _context.DonateServicePartnersers
            //    .FirstOrDefaultAsync(m => m.DonateServicePartnersId == id);
            //var popp = _context.Partners.Where(p => p.PartnerId == donateServicePartners.PartnerId);



            //var donateServicePartners = await _context.DonateServicePartnersers
            //    .FirstOrDefaultAsync(m => m.DonateServicePartnersId == id);
            //var lat = _context.Partners.Where(p => p.PartnerId == donateServicePartners.PartnerId);
            //partner.PartnerId = donateServicePartners.PartnerId;
            //string latt = partner.PartnerLat;
            //string longg = partner.PartnerLong;
            //var location = partner.PartnerLat;


            //return View(latt, longg);
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
        public IActionResult Create(Partner partner, DonateServicePartners donateServicePartners, DonateService donateService)
        {

            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["PartnerId"] = new SelectList(_context.DonateServices, "PartnerId", "DonateServiceId");
            ViewData["DonateserviceId"] = new SelectList(_context.DonateServices, "DonateServiceId");
            
            //donateServicePartners.PartnerId = partner.PartnerId;
            return View();
        }

        // POST: DonateServicePartners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DonateServiceId")] DonateServicePartners donateServicePartners, Partner partner, DonateService donateService)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var viewerInDb = _context.Partners.Where(m => m.IdentityUserId == userId).FirstOrDefault();
                var applicationDbContext = _context.Partners.Include(p => p.IdentityUser);
                donateServicePartners.PartnerId = viewerInDb.PartnerId;
                var Id = _context.DonateServices.Include(i => i.DonateServiceId);
                //donateServicePartners.DonateServiceId = donateService.DonateServiceId;
                //Set up logic for setting current DonateServiceId
                //var Id = _context.DonateServices.Where(i => i.DonateServiceId == donateServicePartners.DonateServiceId);
               
                //donateServicePartners.DonateServiceId = Id;
                _context.Add(donateServicePartners);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           
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
