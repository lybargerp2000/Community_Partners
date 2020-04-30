using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CommunityPartners.Contracts;
using CommunityPartners.Data;
using CommunityPartners.MapViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CommunityPartners.Controllers
{
    public class MapViewController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IGeoCodeRequest _geoCodeRequest;
        public MapViewController(ApplicationDbContext context, IGeoCodeRequest geoCodeRequest)
        {
            _context = context;
            _geoCodeRequest = geoCodeRequest;
        }
        public async Task<IActionResult> SelectRadius()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var viewerInDb = _context.Partners.Where(m => m.IdentityUserId == userId).FirstOrDefault();
            var applicationDbContext = _context.Partners.Include(p => p.IdentityUser);

            return View(viewerInDb);


        }
        public IActionResult Index()
        {
            return View();
        }
    }
}