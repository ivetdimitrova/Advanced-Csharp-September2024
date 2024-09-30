using System.Runtime.InteropServices;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);

        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using StreamReader input1 = new StreamReader(firstInputFilePath);

           using  StreamReader input2 = new StreamReader(secondInputFilePath);

           using  StreamWriter output = new StreamWriter(outputFilePath);

           string[] introduction1 = input1.ReadToEnd().Split().ToArray();
            string[] introduction2 = input2.ReadToEnd().Split().ToArray();

           if (introduction1.Length > introduction2.Length)
           {
               for (int i = 0; i < introduction1.Length; i++)
               {
                    output.WriteLine(introduction1[i]);
                   if (i <= introduction2.Length)
                   {
                       output.WriteLine(introduction2[i]);
                    }
                   i++;
               }
           }
           else if (introduction2.Length > introduction1.Length)
           {
               for (int i = 0; i < introduction2.Length; i++)
               {
                   if (i <= introduction1.Length)
                   {
                       output.WriteLine(introduction1[i]);
                   }

                   output.WriteLine(introduction1[i]);
                    i++;
               }
            }
           else
           {
               for (int i = 0; i < introduction1.Length; i++)
               {
                   output.WriteLine(introduction1[i]);
                   output.WriteLine(introduction2[i]);
                   i++;
               }
            }
        }

    }

}