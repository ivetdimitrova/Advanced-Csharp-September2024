namespace _07.RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Car[] cars = new Car[count];
            for (int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split(" " , StringSplitOptions.RemoveEmptyEntries).ToArray();


                Engine engine = new Engine(int.Parse(data[2]), int.Parse(data[1]));
                Cargo cargo = new Cargo(int.Parse(data[3]), data[4]);

                Tire[] tires = new Tire[4];
                int dataPressureIndex = 5;
                int dataAgeIndex = 6;
                ;
                for (int j = 0; j < tires.Length; j++)
                {
                    Tire tire = new Tire(double.Parse(data[dataPressureIndex]), int.Parse(data[dataAgeIndex]));

                    tires[j] = tire;
                    dataPressureIndex += 2;
                    dataAgeIndex += 2;
                }
                

                Car car = new Car(data[0], engine, cargo,tires);

                cars[i] = car;
            }

            string type = Console.ReadLine();

            PrintAllCarsFromThisType(type,cars);
        }

        private static void PrintAllCarsFromThisType(string? type, Car[] cars)
        {
            switch (type)
            {
                case "fragile":
                    foreach (Car car in cars)
                    {
                        foreach (Tire tire in car.Tires)
                        {
                            if (tire.Pressure < 1)
                            {
                                Console.WriteLine($"{car.Model}");
                                break;
                            }
                        }
                    }
                    break;
                case "flammable":
                    foreach (Car car in cars)
                    {
                       if (car.Engine.Power > 250)
                       {
                            Console.WriteLine($"{car.Model}");
                       }
                    }
                    break;
            }
        }
    }
}
