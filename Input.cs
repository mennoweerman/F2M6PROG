using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex_opdracht_PROG
{
    class Input
    {
        public Pokedex StartPokemon { get; set; }
        public Pokedex currentPokemon { get; set; }

        public Input()
        {
            
        }
        
        public int AskForInput(int maxNumber)
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input < maxNumber)
                {
                    return input;
                }
                Console.WriteLine("Invalid Input: Option not available");
            }
            else
            {
                Console.WriteLine("Invalid Input: Please insert a number");
            }
            return AskForInput(maxNumber);
        }
    }
}
