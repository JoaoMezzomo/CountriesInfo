using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using CountriesApi.Interfaces;
using CountriesApi.Services;

namespace CountriesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly string _defaultFields = "name,independent,currencies,region,subregion,languages,borders,area,maps,population,continents,flags,coatOfArms";
        private readonly ICountryService _countryService;

        public CountryController(IConfiguration configuration)
        {
            _countryService = new CountryService(configuration);
        }

        [HttpGet("GetAll")]
        public async Task<string?> GetAll(string? fields)
        {
            if (string.IsNullOrEmpty(fields))
            {
                fields = _defaultFields;
            }

            try
            {
                return await _countryService.GetAll(fields);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpGet("GetFromName")]
        public async Task<string?> GetFromName(string? fields, string name)
        {
            if (string.IsNullOrEmpty(fields))
            {
                fields = _defaultFields;
            }

            try
            {
                return await _countryService.GetFromName(fields, name);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpGet("GetFromRegion")]
        public async Task<string?> GetFromRegion(string? fields, string region)
        {
            if (string.IsNullOrEmpty(fields))
            {
                fields = _defaultFields;
            }

            try
            {
                return await _countryService.GetFromRegion(fields, region);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpGet("GetFromSubRegion")]
        public async Task<string?> GetFromSubRegion(string? fields, string subRegion)
        {
            if (string.IsNullOrEmpty(fields))
            {
                fields = _defaultFields;
            }

            try
            {
                return await _countryService.GetFromSubRegion(fields, subRegion);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpGet("GetFromCurrency")]
        public async Task<string?> GetFromCurrency(string? fields, string currency)
        {
            if (string.IsNullOrEmpty(fields))
            {
                fields = _defaultFields;
            }

            try
            {
                return await _countryService.GetFromCurrency(fields, currency);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpGet("GetFromLanguages")]
        public async Task<string?> GetFromLanguages(string? fields, string language)
        {
            if (string.IsNullOrEmpty(fields))
            {
                fields = _defaultFields;
            }

            try
            {
                return await _countryService.GetFromLanguages(fields, language);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}