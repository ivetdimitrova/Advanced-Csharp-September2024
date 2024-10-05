using System.Text;

namespace _08.CarSalesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Engine> engines = new Dictionary<string,Engine>();
            List<Car> cars = new List<Car>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = data[0];
                int power = int.Parse(data[1]);
                int? displacement = null;
                string? efficiency = null;

                if (data.Length == 3)
                {
                    if (int.TryParse(data[2], out int numericValue))
                        displacement = numericValue;
                    else
                        efficiency = data[2];
                }
                else if (data.Length == 4)
                {
                    displacement = int.Parse(data[2]);
                    efficiency = data[3];
                }

                Engine engine = new Engine(model, power, displacement, efficiency);


                if (engines.ContainsKey(model))
                {
                    engines.Add(model,new Engine());
                }

                engines[model] = engine;
            }

            count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = data[0];
                string engineModel = data[1];
                Engine engine = GetEngine(engines, engineModel);
                int? weight = null;
                string? color = null;
                
                 if (data.Length == 3)
                {

                    if (int.TryParse(data[2], out int numericValue))
                        weight = numericValue;
                    else
                        color = data[2];
                }
                else if (data.Length == 4)
                {
                    weight = int.Parse(data[2]);
                    color = data[3];

                }

                Car car = new Car(model, engine, weight, color);
                 cars.Add(car);
            }

            PrintCarsInfo(cars);
        }

        public static void PrintCarsInfo(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }

        }

        public static Engine GetEngine(Dictionary<string, Engine> engines, string engineModel)
        {
            Engine searchEgine = null;
            foreach (var (model,engine) in engines)
            {
                if (engine.Model == engineModel)
                {
                    searchEgine =  engine;
                }
            }

            return searchEgine;
        }
    }
}
