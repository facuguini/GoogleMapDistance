using Newtonsoft.Json;
using Parcial1_TFI_FacundoGuini.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.API
{
    public class GoogleMaps
    {
        const string ORIGIN_ADDRESS = "Aramburu%202052,%20Martinez,%20Buenos%20Aires,%20Argentina";
        const string API_KEY = "AIzaSyD6pyi90GbsqRTj6zrr1t-w67NH_dfplGA";

        public async Task<GoogleMapsDistanceResponse> GetData(string address)
        {
            HttpClient client = new HttpClient();
            var url = "https://maps.googleapis.com/maps/api/directions/json?origin=" + ORIGIN_ADDRESS + "&destination=" + address + "&waypoints=optimize:true|&key=" + API_KEY;
            var result = await client.GetAsync(string.Format(url));
            GoogleMapsDistanceResponse response = JsonConvert.DeserializeObject<GoogleMapsDistanceResponse>(await result.Content.ReadAsStringAsync());
            return response;
        }
    }
}