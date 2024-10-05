using System.Text;

namespace DirectoryTraversal
{
    using System;

    public class DirectoryTraversal
    {
        static void Main()
        {

            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);

        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string Information = string.Empty;
            DirectoryInfo directory = new DirectoryInfo(inputFolderPath);

            FileInfo[] allFiles = directory.GetFiles();

            Dictionary<string, List<FileInfo>> information = new Dictionary<string, List<FileInfo>>();

            foreach (FileInfo file in allFiles)
            {
                if (!information.ContainsKey(file.Extension))
                {
                    information.Add(file.Extension,new List<FileInfo>());
                }

                information[file.Extension].Add(file);
            }

            StringBuilder result = new StringBuilder();

            foreach (var (extension, relatedFiles) in information.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                 result.AppendLine($"{extension}");

                foreach (FileInfo file in relatedFiles.OrderByDescending(x => x.Length))
                {
                    double size = file.Length / 1024.0;
                    result.AppendLine($"--{file.Name} - {size}kb");
                }
            }

            return result.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string outputFilePath = Path.Combine(desktopPath, reportFileName);

            File.WriteAllText(desktopPath, textContent);
        }

    }

}