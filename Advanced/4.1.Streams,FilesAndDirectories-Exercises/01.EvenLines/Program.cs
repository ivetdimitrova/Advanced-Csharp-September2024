using System.Diagnostics.Metrics;
using System.Text;

namespace EvenLines
{
    using System;
    using System.Reflection.PortableExecutable;

    public class EvenLines
    {
        static void Main()
        {

            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));

        }



        public static string ProcessLines(string inputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);

            string replacedLines = string.Empty;
            for (int j = 0; j < lines.Length; j++)
            {
                string line = lines[j];
                if (j % 2 == 0)
                {
                    replacedLines += Replace(line) + "\n";
                }
            }

            return replacedLines;
        }

        private static string Replace(string line)
        {
            string newLine = string.Empty;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '-'|| line[i] == ',' || line[i] == '.' || line[i] == '!' || line[i] == '?')
                {
                    line = line.Replace(line[i], '@');
                }
                
            }

            string[] wordsInLine = line.Split().ToArray();
            for (int j = wordsInLine.Length - 1; j > 0; j--)
            {
                newLine += wordsInLine[j] + " ";
            }

            return newLine;
        }

    }
}