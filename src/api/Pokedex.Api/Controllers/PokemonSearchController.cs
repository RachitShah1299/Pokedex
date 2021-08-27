using Microsoft.AspNetCore.Mvc;
using Pokedex.Api.Services;

namespace Pokedex.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonSearchController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        public PokemonSearchController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet("[action]/{name}")]
        public async Task<IActionResult> SearchPokemon(string name)
        {
            try
            {
                return Ok(await _pokemonService.SearchByName(name));
            }
            catch
            {
                return NotFound();
            }
        }
    }
}