using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.Entities
{
    public class ShipmentType
    {
        public string Name { get; set; }
        public Days Days { get; set; }
        public double Price { get; set; }
    }

    public class Days
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }
}