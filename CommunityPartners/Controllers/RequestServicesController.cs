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
    public class RequestServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RequestServicesController(ApplicationDbContext context)
        {
            _context = context;
            
        }
        public IActionResult AcceptRequest()
        {
            return View();
        }
        // GET: RequestServices
        public async Task<IActionResult> Index()
        {
            return View(await _context.RequestServices.ToListAsync());
        }
        public async Task<IActionResult> MapViewRequest(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestService = await _context.RequestServices
                .FirstOrDefaultAsync(m => m.RequestServiceId == id);
            if (requestService == null)
            {
                return NotFound();
            }

            return View(requestService);
        }

        // GET: RequestServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestService = await _context.RequestServices
                .FirstOrDefaultAsync(m => m.RequestServiceId == id);
            if (requestService == null)
            {
                return NotFound();
            }

            return View(requestService);
        }

        // GET: RequestServices/Create
        public IActionResult Create()
        {
            ViewData["PartnerId"] = new SelectList(_context.Partners, "PartnerId");
            return View();
        }

        // POST: RequestServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RequestService requestService)
        {
            if (ModelState.IsValid)
            {

                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                Partner currentpartner = _context.Partners.Where(v => v.IdentityUserId == userId).FirstOrDefault();

                var partnerId = currentpartner.PartnerId;
                //var testvariable = currentpartner.PartnerId;
                _context.Add(requestService);
                _context.Partners.Update(currentpartner);
                _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PartnerId"] = new SelectList(_context.Partners, "PartnerId");
            //ViewData["WeekendLocationId"] = new SelectList(_context.ViewerLocation, "ViewerLocationId", "ViewerLocationId", wWindow.WeekendLocationId);
            return RedirectToAction(nameof(Index));
        }
        //public async Task<IActionResult> Create(RequestService requestService)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(requestService);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //    }
        //    return View(requestService);
        //}

        // GET: RequestServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestService = await _context.RequestServices.FindAsync(id);
            if (requestService == null)
            {
                return NotFound();
            }
            return View(requestService);
        }

        // POST: RequestServices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequestServiceId,PartnerId,PayPalId,RequestDate,RequestItem,GroceryList,AcceptRequest,RequestDayOfWeek,TransactionAmount,RatingEntry")] RequestService requestService)
        {
            if (id != requestService.RequestServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requestService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequestServiceExists(requestService.RequestServiceId))
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
            return View(requestService);
        }

        // GET: RequestServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requestService = await _context.RequestServices
                .FirstOrDefaultAsync(m => m.RequestServiceId == id);
            if (requestService == null)
            {
                return NotFound();
            }

            return View(requestService);
        }

        // POST: RequestServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var requestService = await _context.RequestServices.FindAsync(id);
            _context.RequestServices.Remove(requestService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequestServiceExists(int id)
        {
            return _context.RequestServices.Any(e => e.RequestServiceId == id);
        }
    }
}
