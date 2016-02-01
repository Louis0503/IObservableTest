using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObservable
{
    /// <summary>
    /// Location Struct
    /// </summary>
    public struct Location
    {
        double lat, lon;
        public Location(double latitude, double longitude)
        {
            this.lat = latitude;
            this.lon = longitude;
        }

        public double Latitude
        { get { return this.lat; } }

        public double Longitude
        { get { return this.lon; } }
    }

    /// <summary>
    /// UnKnownLocation Exception
    /// </summary>

    public class LocationUnknownException : Exception
    {
        internal LocationUnknownException()
        { }
    }
}
