using System.Net.Http.Json;
using Pokedex.Api.Contracts;

namespace Pokedex.Api.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly string _url = "https://pokeapi.co/api/v2/pokemon/";
        private readonly IHttpClientFactory _httpClientFactory;
        public PokemonService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public Task<PokemonSearch> SearchByName(string name)
        {

            var httpClient = _httpClientFactory.CreateClient();
            return httpClient.GetFromJsonAsync<PokemonSearch>(_url + name)!;
        }
    }
}