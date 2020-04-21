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
    public class RequestServicePartnersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RequestServicePartnersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RequestServicePartners
        public async Task<IActionResult> Index()
        {
            return View(await _context.RequestServicePartnersers.ToListAsync());
        }

        // GET: RequestServicePartners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestServicePartners = await _context.RequestServicePartnersers
                .FirstOrDefaultAsync(m => m.RequestServicePartnersId == id);
            if (requestServicePartners == null)
            {
                return NotFound();
            }

            return View(requestServicePartners);
        }

        // GET: RequestServicePartners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RequestServicePartners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequestServicePartnersId,PartnerId,ProposalDate,Accepted,RatingHelpfulnessId,PayPalId")] RequestServicePartners requestServicePartners)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requestServicePartners);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requestServicePartners);
        }

        // GET: RequestServicePartners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestServicePartners = await _context.RequestServicePartnersers.FindAsync(id);
            if (requestServicePartners == null)
            {
                return NotFound();
            }
            return View(requestServicePartners);
        }

        // POST: RequestServicePartners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequestServicePartnersId,PartnerId,ProposalDate,Accepted,RatingHelpfulnessId,PayPalId")] RequestServicePartners requestServicePartners)
        {
            if (id != requestServicePartners.RequestServicePartnersId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requestServicePartners);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequestServicePartnersExists(requestServicePartners.RequestServicePartnersId))
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
            return View(requestServicePartners);
        }

        // GET: RequestServicePartners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestServicePartners = await _context.RequestServicePartnersers
                .FirstOrDefaultAsync(m => m.RequestServicePartnersId == id);
            if (requestServicePartners == null)
            {
                return NotFound();
            }

            return View(requestServicePartners);
        }

        // POST: RequestServicePartners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var requestServicePartners = await _context.RequestServicePartnersers.FindAsync(id);
            _context.RequestServicePartnersers.Remove(requestServicePartners);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequestServicePartnersExists(int id)
        {
            return _context.RequestServicePartnersers.Any(e => e.RequestServicePartnersId == id);
        }
    }
}
