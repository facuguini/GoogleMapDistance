using Parcial1_TFI_FacundoGuini.API;
using Parcial1_TFI_FacundoGuini.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.Logic
{
    public class DistanceLogic
    {
        public async Task<Distance> get(string address)
        {
            var response = await new GoogleMaps().GetData(address);
            return response.Routes[0].Legs[0].Distance;
        }
    }
}