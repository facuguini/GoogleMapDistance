using Parcial1_TFI_FacundoGuini.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.Logic
{
    public class PriceLogic
    {
        const int LIMIT_DISTANCE = 10000;
        const double MIN_PRICE = 80.0;
        const double PRICE_PER_KM = 10.0;

        public async Task<PriceResponse> get(string address)
        {
            var distance = await new DistanceLogic().get(address);
            return new PriceResponse()
            {
                Distance = distance.text,
                Price = calculate(distance.value)
            };
        }

        public double calculate(int distance)
        {
            double price = MIN_PRICE;
            if (distance > LIMIT_DISTANCE)
            {
                double remainder = (distance - LIMIT_DISTANCE) / 1000;
                int remainderKms = Convert.ToInt32(Math.Round(remainder, 0));
                for (var i = 0; i < remainderKms; i++)
                {
                    price += PRICE_PER_KM;
                }
            }
            return price;
        }
    }
}