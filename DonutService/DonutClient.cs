using MockAssessment7.DonutService.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MockAssessment7.DonutService
{
    public class DonutClient : ISearchDonut
    {
        private readonly HttpClient httpClient;
        public DonutClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Donut> SearchDonut(int id)
        {
            var response = await httpClient.GetAsync($"https://grandcircusco.github.io/demo-apis/donuts/{id}.json");
            var donut = JsonConvert.DeserializeObject<Donut>(await response.Content.ReadAsStringAsync());
            return donut;
        }
    }
}
