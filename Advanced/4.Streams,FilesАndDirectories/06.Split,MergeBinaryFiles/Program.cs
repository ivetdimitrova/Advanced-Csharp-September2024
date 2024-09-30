using System.Reflection.Metadata.Ecma335;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {

            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);

        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] fileBytes = File.ReadAllBytes(sourceFilePath);

            int part1Sizes = (fileBytes.Length + 1) / 2;
            int part2Size = fileBytes.Length - part1Sizes;

            File.WriteAllBytes(partOneFilePath, fileBytes[..part1Sizes]);
            File.WriteAllBytes(partTwoFilePath, fileBytes[part1Sizes..]);
        }



        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
           using FileStream mergeImage = new FileStream(joinedFilePath, FileMode.Create);

           byte[] part1Bytes = File.ReadAllBytes(partOneFilePath);
           mergeImage.Write(part1Bytes, 0, part1Bytes.Length);

           byte[] part2Byte = File.ReadAllBytes(partTwoFilePath);
           mergeImage.Write(part2Byte, 0, part2Byte.Length);

        }

    }

}