using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.Entities
{
    public class GoogleMapsDistanceResponse
    {
        public List<GeocodedWaypoint> GeocodedWaypoints { get; set; }
        public List<Route> Routes { get; set; }
    }

    public class GeocodedWaypoint
    {
        string GeocoderStatus { get; set; }
        bool PartialMatch { get; set; }
        string PlaceId { get; set; }
        List<string> Types { get; set; }
    }

    public class Route
    {
        Bounds Bounds { get; set; }
        string copyrights { get; set; }
        public List<Leg> Legs { get; set; }
    }

    public class Bounds
    {
        LatLng Northeast { get; set; }
        LatLng North { get; set; }
        LatLng Northwest { get; set; }
        LatLng West { get; set; }
        LatLng East { get; set; }
        LatLng SouthEast { get; set; }
        LatLng SouthWest { get; set; }
        LatLng South { get; set; }
    }

    public class LatLng
    {
        float lat { get; set; }
        float lng { get; set; }
    }

    public class Leg
    {
        public Distance Distance { get; set; }
        public Duration Duration { get; set; }
    }

    public class Distance
    {
        public string text { get; set; }
        public int value { get; set; }
    }

    public class Duration
    {
        string text { get; set; }
        int value { get; set; }
    }
}