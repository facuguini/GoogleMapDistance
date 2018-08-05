using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.Entities.HereResponse
{
    public class HereResponse
    {
        public Response Response { get; set; }
    }

    public class Response
    {
        public List<Route> Route { get; set; }
    }

    public class Route
    {
        public Summary Summary { get; set; }
    }

    public class Summary
    {
        public int BaseTime { get; set; }
        public int Distance { get; set; }
    }
}