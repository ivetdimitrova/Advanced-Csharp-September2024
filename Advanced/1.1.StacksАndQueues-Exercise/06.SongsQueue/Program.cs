namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));

          
            while (songs.Count > 0)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                
                switch (command[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string song = command[1];

                        if (command.Length > 2)
                        {
                            for (int i = 2; i < command.Length; i++)
                                song +=" " + command[i];
                        }
                       
                        if (songs.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                            break;
                        }

                        songs.Enqueue(song);
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",songs));
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
