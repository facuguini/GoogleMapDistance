using Newtonsoft.Json;
using Parcial1_TFI_FacundoGuini.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.Configs
{
    public class ConfigManager
    {
        CONFIG CONFIG = new CONFIG();
        public ConfigManager()
        {
            CONFIG.VEHICLE = "Vehicle.json";
            CONFIG.TYPE = "Type.json";
            CONFIG.PRICE = "Price.json";
        }

        public object Get(string config = "")
        {
            config = config.ToUpper();
            object configs;
            switch(config)
            {
                case "VEHICLE":
                    configs = GetVehicles();
                    break;
                case "TYPE":
                    configs = GetTypes();
                    break;
                case "PRICE":
                    configs = GetPrices();
                    break;
                default:
                    throw new Exception(String.Format("The config {0} do not exists.", config));
            }
            return configs;
        }

        private List<Vehicle> GetVehicles()
        {
            var json = Read(CONFIG.VEHICLE);
            return JsonConvert.DeserializeObject<List<Vehicle>>(json);
        }

        private List<ShipmentType> GetTypes()
        {
            var json = Read(CONFIG.TYPE);
            return JsonConvert.DeserializeObject<List<ShipmentType>>(json);
        }

        private Dictionary<string, object> GetPrices()
        {
            var json = Read(CONFIG.PRICE);
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
        }

        private string Read(string file)
        {
            string data = String.Empty;
            try
            {
                StreamReader r = new StreamReader(string.Format("{0}/{1}", HttpContext.Current.Server.MapPath("~/configs"), file));
                data = r.ReadToEnd();
            } catch(Exception ex)
            {
                throw ex;
            }
            return data;
        }
    }
    public struct CONFIG
    {
        public string VEHICLE;
        public string TYPE;
        public string PRICE;
    }
}