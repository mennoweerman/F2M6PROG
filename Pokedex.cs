using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex_opdracht_PROG
{
    internal class Pokedex
    {
        public List<Pokemon> pokemons { get; private set; }
        public List<PokemonType> pokeTypes { get; private set; }

        public Pokedex()
        {
            pokemons = new List<Pokemon>();
            pokeTypes = new List<PokemonType>();
        }

        public void AddPokemon(Pokemon nieuwePokemon)
        {
            pokemons.Add(nieuwePokemon);
        }

        public List<Pokemon> GetPokemons()
        {
            return pokemons;
        }
    }
}
