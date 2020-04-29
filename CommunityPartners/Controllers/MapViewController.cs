using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityPartners.Contracts;
using CommunityPartners.Data;
using CommunityPartners.MapViewModels;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> SelectState()
        {
            MapView mapView = new MapView();

            return View(mapView);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}