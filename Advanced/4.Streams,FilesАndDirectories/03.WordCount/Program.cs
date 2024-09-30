namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);

        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using StreamReader words = new StreamReader(wordsFilePath);

            using StreamReader text = new StreamReader(textFilePath);

            using StreamWriter output = new StreamWriter(outputFilePath);

            string[] searchingWords = words.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, int> countByWord = new Dictionary<string, int>();

            string line = String.Empty;
            while ((line = text.ReadLine()) != null)
            {
                List<string> listOfLine = line.Split(new[] { ' ', '!', '?', '.', ',', '-' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < searchingWords.Length; i++)
                {
                    string searchWord = searchingWords[i];
                    //int counter = 0;

                    if (!countByWord.ContainsKey(searchWord))
                    {
                        countByWord.Add(searchWord, 0);
                    }

                    //if (listOfLine.Contains(searchWord))
                    //{

                    searchWord = searchWord.ToLower();


                    for (int j = 0; j < listOfLine.Count; j++)
                    {
                        if (listOfLine[j].ToLower() == searchWord)
                        {
                            countByWord[searchWord]++;
                        }
                    }
                    //}
                }
            }

            var sortedCountByWord = countByWord.OrderByDescending(x => x.Value);

            foreach (var (word, count) in sortedCountByWord)
            {
                output.WriteLine($"{word} - {count}");
            }



        }

    }

}