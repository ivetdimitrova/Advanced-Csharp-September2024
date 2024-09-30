using System.Diagnostics.CodeAnalysis;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {

            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);

        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        { 
            DirectoryInfo directory = new DirectoryInfo(folderPath);
           
            long allSize = 0;
            if (directory.Exists)
            {
                 allSize += GetFileSize(directory);

                DirectoryInfo[] directories = directory.GetDirectories();

                if (directories.Length > 0)
                {
                    for (int i = 0; i < directories.Length; i++)
                    {
                        allSize += GetFileSize(directories[i]);
                    }
                }

            }
           
            using StreamWriter writer = new StreamWriter(outputFilePath);
            writer.Write($"{allSize / 1024.0} KB");

        }

        private static long GetFileSize(DirectoryInfo directory)
        {
            long size = 0;
            FileInfo[] files = directory.GetFiles();
            if (files.Length > 0)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo file = files[i];
                    size += file.Length;
                }

            }

            return size;
        }
    }

}