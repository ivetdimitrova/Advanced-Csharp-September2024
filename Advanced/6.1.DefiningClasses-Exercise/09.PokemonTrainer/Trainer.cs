using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
            Pokemons = new List<Pokemon>();
        }

        public string Name { get; }
        public int NumberOfBadges { get; private set; }
        public List<Pokemon> Pokemons { get; }

        public void CheckingPokemons(string element)
        {
            int pokemonsWithElement = 0;
            foreach (Pokemon pokemon in this.Pokemons)
            {
                if (pokemon.Element == element)
                {
                    pokemonsWithElement++;
                }

            }

            if (pokemonsWithElement > 0)
            {
                this.NumberOfBadges++;
            }
            else
            {
                foreach (Pokemon pokemon in this.Pokemons)
                {
                    pokemon.Health -= 10;

                    if (pokemon.Health <= 0)
                    {
                        this.Pokemons.Remove(pokemon);
                        break;
                    }
                }
            }
        }

       public static string PrintTrainers(List<Trainer> trainers)
       {
           StringBuilder resultBuilder = new StringBuilder();

           foreach (var trainer in trainers)
           {
               resultBuilder.AppendLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
           }

           return resultBuilder.ToString();
       }
    }
}
