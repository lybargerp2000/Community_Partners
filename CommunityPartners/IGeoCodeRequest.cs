using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityPartners.Models;

namespace CommunityPartners.Contracts
{
    public interface IGeoCodeRequest
    {
        Task<GeoLocation> GetGeoLocation(string address);
    }
}
