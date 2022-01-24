using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex_opdracht_PROG
{
     public abstract class PokemonType
    {
        public List<PokemonType> weaknesses { get; private set; }
        public string pokemontype { get; private set; }
        public PokemonType(string aType)
        {
            pokemontype = aType;
            weaknesses = new List<PokemonType>();
        }
        public bool CheckWeakness(PokemonType typeToCheckAgainst)
        {
            //kijken in het lijstje of de pokemontype erin staat, en dan ja of nee teruggeven.//
            bool isWeakAgainst = weaknesses.Contains(typeToCheckAgainst);
            return isWeakAgainst;
        }
        public void AddWeakness(PokemonType newPokemonType)
        {
            weaknesses.Add(newPokemonType);
        }

    }
}
