using Parcial1_TFI_FacundoGuini.Configs;
using Parcial1_TFI_FacundoGuini.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.Logic
{
    public class VehicleLogic
    {
        public List<Vehicle> Get()
        {
            return (List<Vehicle>) new ConfigManager().Get("VEHICLE");
        }

        public Vehicle GetByName(string name)
        {
            return Get().FirstOrDefault(x => x.Name == name);
        }
    }
}