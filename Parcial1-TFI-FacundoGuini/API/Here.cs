using Newtonsoft.Json;
using Parcial1_TFI_FacundoGuini.Entities;
using Parcial1_TFI_FacundoGuini.Entities.HereGeocoder;
using Parcial1_TFI_FacundoGuini.Entities.HereResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.API
{
    public class Here
    {
        const string ORIGIN_ADDRESS = "Aramburu 2052, Martinez, Buenos Aires, Argentina";
        const string APP_ID = "qpZx8OkZV6G7mSDEj6bo";
        const string APP_CODE = "ALF9e8JyZTB4s_2AwlDLQw";

        public async Task<HereResponse> GetData(string address)
        {
            HereGeocoder Origin = await Geocode(ORIGIN_ADDRESS);
            HereGeocoder Destination = await Geocode(address);
            HttpClient client = new HttpClient();
            var url = string.Format("https://route.api.here.com/routing/7.2/calculateroute.json?app_id={0}&app_code={1}&waypoint0=geo!{2},{3}" +
                "&waypoint1=geo!{4},{5}&mode=fastest;car",
                APP_ID,
                APP_CODE,
                Origin.Response.View[0].Result[0].Location.DisplayPosition.Latitude.ToString().Replace(",", "."),
                Origin.Response.View[0].Result[0].Location.DisplayPosition.Longitude.ToString().Replace(",", "."),
                Destination.Response.View[0].Result[0].Location.DisplayPosition.Latitude.ToString().Replace(",", "."),
                Destination.Response.View[0].Result[0].Location.DisplayPosition.Longitude.ToString().Replace(",", ".")
                );
            var result = await client.GetAsync(string.Format(url));
            HereResponse response = JsonConvert.DeserializeObject<HereResponse>(await result.Content.ReadAsStringAsync());
            return response;
        }

        private async Task<HereGeocoder> Geocode(string address)
        {
            HttpClient client = new HttpClient();
            var url = string.Format("https://geocoder.api.here.com/6.2/geocode.json?app_id={0}&app_code={1}&searchtext={2}", APP_ID, APP_CODE, address);
            var result = await client.GetAsync(string.Format(url));
            HereGeocoder response = JsonConvert.DeserializeObject<HereGeocoder>(await result.Content.ReadAsStringAsync());
            return response;
        }
    }
}