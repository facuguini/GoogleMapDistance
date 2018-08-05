using Parcial1_TFI_FacundoGuini.Configs;
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
        private int LIMIT_DISTANCE;
        private double MIN_PRICE;
        private double PRICE_PER_KM;

        public PriceLogic()
        {
            Dictionary<string, object> configs = (Dictionary<string, object>)new ConfigManager().Get("PRICE");
            LIMIT_DISTANCE = Convert.ToInt32(configs["limit"]);
            MIN_PRICE = Convert.ToDouble(configs["min"]);
            PRICE_PER_KM = Convert.ToDouble(configs["km"]);
        }

        public async Task<PriceResponse> Get(string address, string shipmentTypeName, string vehicleName)
        {
            var distance = await new DistanceLogic().Get(address);
            var vehicle = new VehicleLogic().GetByName(vehicleName);
            var shipmentType = new ShipmentTypeLogic().GetByName(shipmentTypeName);
            return new PriceResponse()
            {
                Distance = string.Format("{0} km", Math.Round((double) distance / 1000, 2)),
                Price = calculate(distance, shipmentType, vehicle),
                DeliveryDateRange = new DateLogic().Get(shipmentType)
            };
        }

        public double calculate(int distance, ShipmentType type, Vehicle vehicle)
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
            return price * type.Price * vehicle.Price;
        }
    }
}