using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.Entities
{
    public class PriceResponse
    {
        public string Distance { get; set; }
        public double Price { get; set; }
        public DateRange DeliveryDateRange { get; set; }
    }
}