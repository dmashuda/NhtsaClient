using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nhtsa
{
    public class NhtsaClient
    {
        private readonly string _apiUrl;
        private readonly HttpClient _client;

        public NhtsaClient(string apiUrl = "https://vpic.nhtsa.dot.gov/")
        {
            _apiUrl = apiUrl;
            _client = new HttpClient {BaseAddress = new Uri(apiUrl)};
        }


        public async Task<NhtsaResult<NhtsaManufacturer>> GetAllManufacturers(int page = 1)
        {
            var response = await _client.GetAsync("/api/vehicles/getallmanufacturers?format=json&page=" + page);

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsAsync<NhtsaResult<NhtsaManufacturer>>();
            return result;
        }
        
        public async Task<NhtsaResult<NhtsaMake>> GetAllMakes()
        {
            var response = await _client.GetAsync("/api/vehicles/GetAllMakes?format=json");

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsAsync<NhtsaResult<NhtsaMake>>();
            return result;
        }
        
        
        public async Task<NhtsaResult<NhtsaManufacturerMakes>> GetMakesForManufacturerAndYear(string manufacturer, int year)
        {
            var response = await _client.GetAsync($"/api/vehicles/GetMakesForManufacturerAndYear/{manufacturer}?year={year}&format=json");

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsAsync<NhtsaResult<NhtsaManufacturerMakes>>();
            return result;
        }
        
        public async Task<NhtsaResult<NhtsaModel>> GetModelsForMake(int makeId)
        {
            var response = await _client.GetAsync($"/api/vehicles/GetModelsForMakeId/{makeId}?format=json");

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsAsync<NhtsaResult<NhtsaModel>>();
            return result;
        }
        
        public async Task<NhtsaResult<NhtsaModel>> GetModelsForMakeIdYear(int makeId, int year)
        {
            var response = await _client.GetAsync($"/api/vehicles/GetModelsForMakeIdYear/makeId/{makeId}/modelyear/{year}?format=json");

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsAsync<NhtsaResult<NhtsaModel>>();
            return result;
        }
    }
}