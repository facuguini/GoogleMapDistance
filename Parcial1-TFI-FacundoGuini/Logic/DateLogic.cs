using Parcial1_TFI_FacundoGuini.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.Logic
{
    public class DateLogic
    {
        public DateRange Get(ShipmentType shipmentType)
        {
            var now = DateTime.Now;
            var range = new DateRange();
            int count = 1, i = 1;
            while(count <= shipmentType.Days.Max)
            {
                var dateAux = now.AddDays(i);
                if(dateAux.DayOfWeek != DayOfWeek.Saturday && dateAux.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (shipmentType.Days.Min == count) range.Min = dateAux;
                    if (shipmentType.Days.Max == count) range.Max = dateAux;
                    count++;
                }
                i++;
            }
            return range;
        }
    }
}