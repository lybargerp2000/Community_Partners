using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPartners.Models
{
    public class GeoLocation
    {
       //public int GeoLocationId { get; set; }
        public GeoResult[] results { get; set; }
        public string status { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }

    }
    public class GeoResult
    {

        public string formatted_address { get; set; }
        public GeoGeometry geometry { get; set; }
        public string place_id { get; set; }
        public GeoPlus_Code plus_code { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }

    }

    public class GeoGeometry
    {
        public int GeoGeometryId { get; set; }
        public GeoLocation_Location location { get; set; }
        public string location_type { get; set; }
        public GeoViewport viewport { get; set; }
    }

    public class GeoLocation_Location
    {
        public float lat { get; set; }
        public float lng { get; set; }
    }
    public class GeoViewport
    {
        public GeoNortheast northeast { get; set; }
        public GeoSouthwest southwest { get; set; }
    }

    public class GeoNortheast
    {
        public float lat { get; set; }
        public float lng { get; set; }
    }

    public class GeoSouthwest
    {
        public float lat { get; set; }
        public float lng { get; set; }
    }

    public class GeoPlus_Code
    {
        public string compound_code { get; set; }
        public string global_code { get; set; }
    }

    
}
