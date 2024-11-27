using Microsoft.Extensions.Configuration;
using Models.Entities;
using Models.Interfaces;

namespace Bussiness.Logic
{
    public class CityLogic : ICitiesServices
    {
        private ICitiesQueries _citiesQueries;

        public CityLogic(ICitiesQueries citiesQueries)
        {
            _citiesQueries = citiesQueries;
        }

        public async Task<List<City>> GetCities()
        {
            return await _citiesQueries.GetCities();
        }
    }
}
