using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.Entities.HereGeocoder
{
    public class HereGeocoder
    {
        public Response Response { get; set; }
    }

    public class Response
    {
        public List<View> View { get; set; }
    }

    public class View
    {
        public List<Result> Result { get; set; }
    }

    public class Result
    {
        public Location Location { get; set; }
    }
    
    public class Location
    {
        public Address Address { get; set; }
        public DisplayPosition DisplayPosition { get; set; }
    }

    public class DisplayPosition
    {
        public Double Latitude { get; set; }
        public Double Longitude { get; set; }
    }

    public class Address
    {
        public string Label { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
    }
}