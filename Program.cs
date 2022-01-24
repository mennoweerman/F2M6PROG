using System;

namespace Pokedex_opdracht_PROG
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex PokeDex = new Pokedex();
            Input Start = new Input();

            Water water = new Water("Water");
            Grass grass = new Grass("Grass");
            Electric electric = new Electric("Electric");
            Fire fire = new Fire("Fire");

            water.AddWeakness(grass);
            water.AddWeakness(electric);
            grass.AddWeakness(fire);
            fire.AddWeakness(water);

            Pokemon Pichu = new Pokemon("Pichu", electric);
            Pokemon Pikachu = new Pokemon("Pikachu", electric);
            Pokemon Raichu = new Pokemon("Raichu", electric);

            Pokemon Charmander = new Pokemon("Charmander", fire);
            Pokemon Charmeleon = new Pokemon("Charmeleon", fire);
            Pokemon Charizard = new Pokemon("Charizard", fire);

            Pokemon Squirtle = new Pokemon("Squirtle", water);
            Pokemon Wartortle = new Pokemon("Wartortle", water);
            Pokemon Blastoise = new Pokemon("Blastoise", water);

            Pokemon Bulbasaur = new Pokemon("Bulbasaur", grass);
            Pokemon Ivysaur = new Pokemon("Ivysaur", grass);
            Pokemon Venusaur = new Pokemon("Venusaur", grass);



            PokeDex.AddPokemon(Pichu);
            PokeDex.AddPokemon(Pikachu);
            PokeDex.AddPokemon(Raichu);
            PokeDex.AddPokemon(Charmander);
            PokeDex.AddPokemon(Charmeleon);
            PokeDex.AddPokemon(Charizard);
            PokeDex.AddPokemon(Squirtle);
            PokeDex.AddPokemon(Wartortle);
            PokeDex.AddPokemon(Blastoise);
            PokeDex.AddPokemon(Bulbasaur);
            PokeDex.AddPokemon(Ivysaur);
            PokeDex.AddPokemon(Venusaur);

            while (true)
            {
                int choice = Start.AskForInput(6);

                if (choice == 1)
                {
                    foreach (Pokemon p in PokeDex.GetPokemons())
                    {
                        Console.WriteLine("\n" + p.GetName() + ", " + p.pokemonType.pokemontype + "\n");
                    }
                }

                if (choice == 2)
                {
                    foreach (Pokemon p in PokeDex.GetPokemons())
                    {
                        if (p.pokemonType.pokemontype == "Electric")
                        {
                            Console.WriteLine("\n" + p.GetName() + ", " + p.pokemonType.pokemontype + "\n");
                        }

                    }
                }

                if (choice == 3)
                {
                    foreach (Pokemon p in PokeDex.GetPokemons())
                    {
                        if (p.pokemonType.pokemontype == "Fire")
                        {
                            Console.WriteLine("\n" + p.GetName() + ", " + p.pokemonType.pokemontype + "\n");
                        }

                    }
                }

                if (choice == 4)
                {
                    foreach (Pokemon p in PokeDex.GetPokemons())
                    {
                        if (p.pokemonType.pokemontype == "Water")
                        {
                            Console.WriteLine("\n" + p.GetName() + ", " + p.pokemonType.pokemontype + "\n");
                        }

                    }
                }

                if (choice == 5)
                {
                    foreach (Pokemon p in PokeDex.GetPokemons())
                    {
                        if (p.pokemonType.pokemontype == "Grass")
                        {
                            Console.WriteLine("\n" + p.GetName() + ", " + p.pokemonType.pokemontype + "\n");
                        }

                    }
                }
            }
        }
    }
}
