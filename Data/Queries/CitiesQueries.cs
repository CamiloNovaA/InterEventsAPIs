using Dapper;
using Data.Infrastructure;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Models.Entities;
using Models.Interfaces;

namespace Data.Queries
{
    public class CitiesQueries : ICitiesQueries
    {
        private readonly ConnectionStrings _dbContext;

        public CitiesQueries(IOptions<ConnectionStrings> dbContext)
        {
            _dbContext = dbContext.Value;
        }

        public async Task<List<City>> GetCities()
        {
            List<City> cities = [];

            using (var db = new SqlConnection(_dbContext.EventsDBContext))
            {
                string sql = "SELECT * FROM Cities";
                var citiesList = await db.QueryAsync<City>(sql);

                foreach (var city in citiesList) {
                    cities.Add(city);
                }
            }

            return cities;
        }
    }
}
