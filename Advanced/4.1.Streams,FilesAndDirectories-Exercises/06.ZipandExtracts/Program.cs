namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";

            ZipAndExtract.ZipFileToArchive(inputFile, zipArchiveFile);

            string fileNameOnly = Path.GetFileName(inputFile);
            ZipAndExtract.ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {

            using ZipArchive archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create);

            string inputFileName = Path.GetFileName(inputFilePath);
            archive.CreateEntryFromFile(inputFilePath, inputFileName);
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            using ZipArchive archive = ZipFile.OpenRead(zipArchiveFilePath);
            ZipArchiveEntry? entry = archive.GetEntry(fileName);

            if (entry is not null)
                entry.ExtractToFile(outputFilePath);
        }
    }
}