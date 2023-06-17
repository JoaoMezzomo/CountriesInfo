using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesApi.Interfaces
{
    public interface ICountryService
    {
        public Task<string?> GetAll(string? fields);

        public Task<string?> GetFromName(string? fields, string name);

        public Task<string?> GetFromRegion(string? fields, string region);

        public Task<string?> GetFromSubRegion(string? fields, string subRegion);

        public Task<string?> GetFromCurrency(string? fields, string currency);

        public Task<string?> GetFromLanguages(string? fields, string language);
    }
}