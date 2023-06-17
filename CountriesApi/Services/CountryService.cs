using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountriesApi.Interfaces;

namespace CountriesApi.Services
{
    public class CountryService : ICountryService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public CountryService(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _configuration = configuration;
        }

        public async Task<string?> GetAll(string? fields)
        {
            fields = $"?fields={fields}";

            string apiUrl = _configuration["UrlApiRestCountries"] + $"all{fields}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Error while retrieving country: {ex.Message}";
            }
        }

        public async Task<string?> GetFromName(string? fields, string name)
        {
            fields = $"?fields={fields}";

            string apiUrl = _configuration["UrlApiRestCountries"] + $"name/{name}{fields}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Error while retrieving country: {ex.Message}";
            }
        }

        public async Task<string?> GetFromRegion(string? fields, string region)
        {
            fields = $"?fields={fields}";

            string apiUrl = _configuration["UrlApiRestCountries"] + $"region/{region}{fields}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Error while retrieving country: {ex.Message}";
            }        
        }

        public async Task<string?> GetFromSubRegion(string? fields, string subRegion)
        {
            fields = $"?fields={fields}";

            string apiUrl = _configuration["UrlApiRestCountries"] + $"subregion/{subRegion}{fields}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Error while retrieving country: {ex.Message}";
            }        
        }

        public async Task<string?> GetFromCurrency(string? fields, string currency)
        {
            fields = $"?fields={fields}";

            string apiUrl = _configuration["UrlApiRestCountries"] + $"currency/{currency}{fields}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Error while retrieving country: {ex.Message}";
            }
        }

        public async Task<string?> GetFromLanguages(string? fields, string language)
        {
            fields = $"?fields={fields}";

            string apiUrl = _configuration["UrlApiRestCountries"] + $"lang/{language}{fields}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Error while retrieving country: {ex.Message}";
            }
        }
    }
}