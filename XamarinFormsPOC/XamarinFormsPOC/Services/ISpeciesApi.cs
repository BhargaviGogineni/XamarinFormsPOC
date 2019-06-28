using System;
using System.Threading.Tasks;
using Refit;
using XamarinFormsPOC.Models.Response;

namespace XamarinFormsPOC.Services
{
    public interface ISpeciesApi
    {
        [Get("/s/2iodh4vg0eortkl/facts.json")]
        Task<Country> GetSpecies();
    }
}
