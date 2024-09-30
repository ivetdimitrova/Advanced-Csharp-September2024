using System.Text;
using System.Threading.Channels;

namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Stack<string[]> commands = new Stack<string[]>();

            string lastRemovedText = string.Empty;
            string currentText = string.Empty;

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                int commandType = int.Parse(command[0]);
                switch (commandType)
                {
                    case 1:
                        currentText += command[1];
                        commands.Push(command);
                        break;
                    case 2:
                        int eraseCount = int.Parse(command[1]);

                        if (eraseCount - 1 <= currentText.Length - 1)
                        {
                            lastRemovedText  = currentText.Substring(currentText.Length - eraseCount);
                            currentText = currentText.Remove(currentText.Length - eraseCount);
                            commands.Push(new string[] { "2", lastRemovedText  });
                        }
                        
                        break;
                    case 3:
                        int charIndex = int.Parse(command[1]) - 1;

                        if (charIndex <=currentText.Length-1)
                        Console.WriteLine(currentText[charIndex ]);
                        break;
                    case 4:
                        int n = 0;
                        while (commands.Count > 0)
                        {
                            string[] com = commands.Pop();
                            if (com[0] == "1")
                            {
                                currentText = currentText.Remove(currentText.Length - com[1].Length);
                                n++;

                            }
                            else if (com[0] == "2")
                            {
                                currentText += com[1];
                                n++;
                            }

                            if (n == 1) break;

                        } 
                        break;
                }
            }
        }

    }
    
}
