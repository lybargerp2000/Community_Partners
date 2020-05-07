using CommunityPartners.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPartners.MapViewModels
{
    public class MapView
    { public Partner partner { get; set; }
      public GeoLocation geoLocation { get; set; }
      public DonateService[] donateService { get; set; }
      public RateService rateService { get; set; }
      public GeoLocation_Location geoLocation_Location { get; set; }
      public GeoResult[] geoResult { get; set; }
    }
}
