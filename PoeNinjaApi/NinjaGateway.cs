using PoeOil;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PoeOil.PoeNinjaApi
{
    public static class NinjaGateway
    {

        public const string Url = "https://poe.ninja/api/data/itemoverview?league=$league$&type=Oil";
        public const string League = "Blight";
        
        public static Dictionary<Oil, double> GetOilData()
        {
            var data = QueryOilData();

            var dict = new Dictionary<Oil, double>();

            foreach(var line in data?.Lines)
            {
                var oil = Oil.Parse(line.Name);
                dict[oil] = line.ChaosValue;
            }
            return dict;
        }

        private static HttpClient client = new HttpClient();
        private static OilData QueryOilData()
        {
            var fullUrl = Url.Replace("$league$", League);

            var result = client.GetAsync(fullUrl);
            var data = result.Result.Content.ReadAsStringAsync().Result;

            return JsonSerializer.Deserialize<OilData>(data);
        }
    }

    public class OilData
    {
        [JsonPropertyName("lines")]
        public List<OilDataLine> Lines { get; set; }
    }

    public class OilDataLine
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("chaosValue")]
        public double ChaosValue { get; set; }
    }
}
