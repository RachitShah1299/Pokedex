using Pokedex.Api.Contracts;

namespace Pokedex.Api.Services
{
    public interface IPokemonService
    {
        Task<PokemonSearch> SearchByName(string name);
    }
}