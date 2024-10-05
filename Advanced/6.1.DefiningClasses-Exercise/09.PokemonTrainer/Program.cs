using System.Text;

namespace _09.PokemonTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Trainer> trainers = new Dictionary<string,Trainer>();

            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] information = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = information[0];
                string pokemonName = information[1];
                string pokemonElement = information[2];
                int pokemonHealth = int.Parse(information[3]);

                if (!trainers.ContainsKey(name))
                {
                    trainers.Add(name,new Trainer(name));
                }

                trainers[name].Pokemons.Add(new Pokemon(pokemonName,pokemonElement,pokemonHealth));
            }

            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var (name,trainer) in trainers)
                {
                    trainer.CheckingPokemons(command);
                }
            }

            List<Trainer> trainersList = trainers.Values.OrderByDescending(t => t.NumberOfBadges).ToList();

            Console.WriteLine(Trainer.PrintTrainers(trainersList));
        }

    }
}
