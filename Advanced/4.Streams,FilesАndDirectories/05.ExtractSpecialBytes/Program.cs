namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            List<byte> targetBytes = File.ReadAllLines(bytesFilePath)
                .Select(byte.Parse)
                .ToList();

            byte[] inputFileBytes = File.ReadAllBytes(bytesFilePath);

            List<byte> resultBytes = new List<byte>();

            for (int i = 0; i < inputFileBytes.Length; i++)
            {
                byte currentByte = inputFileBytes[i];

                if (targetBytes.Contains(currentByte))
                {
                    resultBytes.Add(currentByte);
                }
            }

            File.WriteAllBytes(outputPath, resultBytes.ToArray());
        }
    }
}