using Parcial1_TFI_FacundoGuini.Configs;
using Parcial1_TFI_FacundoGuini.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.Logic
{
    public class ShipmentTypeLogic
    {
        public List<ShipmentType> Get()
        {
            return (List<ShipmentType>)new ConfigManager().Get("TYPE");
        }

        public ShipmentType GetByName(string name)
        {
            return Get().FirstOrDefault(x => x.Name == name);
        }
    }
}