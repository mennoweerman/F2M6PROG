using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex_opdracht_PROG
{
    internal class Pokemon
    {
        public string name { get; private set; }
        public PokemonType pokemonType { get; private set; }
        

        public Pokemon(string aName, PokemonType aType)
        {
            name = aName;
            pokemonType = aType;
        }

        public string GetName()
        {
            return name;
        }
    }
}
