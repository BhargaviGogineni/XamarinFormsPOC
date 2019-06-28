using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;
using XamarinFormsPOC.Models.Response;

namespace XamarinFormsPOC.Services
{
    public class SpeciesService : ISpeciesApi
    {
        public Country SpeciesList;

        public async Task<Country> GetSpecies()
        {
            try
            {
                HttpClient httpClient = new HttpClient()
                {
                    BaseAddress = new Uri(Helpers.Constants.BaseUrl)
                };

                var nsAPI = RestService.For<ISpeciesApi>(httpClient);
                SpeciesList = await nsAPI.GetSpecies();
            }

            catch (Exception ex)
            {
                Debug.WriteLine("Error in GetSpecies" + ex.Message);
            }

            return SpeciesList;
        }
    }
}
