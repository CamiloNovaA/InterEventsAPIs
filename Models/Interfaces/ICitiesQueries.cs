﻿using Models.Entities;

namespace Models.Interfaces
{
    public interface ICitiesQueries
    {
        Task<List<City>> GetCities();
    }
}
