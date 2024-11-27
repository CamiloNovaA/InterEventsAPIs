using Models.Entities;

namespace Models.Interfaces
{
    public interface ICitiesServices
    {
        Task<List<City>> GetCities();
    }
}
