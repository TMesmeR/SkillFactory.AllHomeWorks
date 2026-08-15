using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Module13._6._2
{
    internal class WordFrequencyAnalyzer
    {
        private readonly string _filePath;
        private readonly Dictionary<string, int> _wordFrequency;

        public WordFrequencyAnalyzer(string filePath)
        {
            _filePath = filePath;
            _wordFrequency = new Dictionary<string, int>();
        }

        public void Analyze()
        {
            try
            {
                // Чтение файла и подсчет частоты каждого слова
                string text = File.ReadAllText(_filePath);
                MatchCollection matches = Regex.Matches(text, @"\b\w+\b");
                foreach (Match match in matches)
                {
                    string word = match.Value.ToLower();
                    if (_wordFrequency.TryGetValue(word, out int count))
                    {
                        _wordFrequency[word] = count + 1;
                    }
                    else
                    {
                        _wordFrequency[word] = 1;
                    }
                }

                // Сортировка слов по частоте и выбор топ-10
                var sortedWords = new List<KeyValuePair<string, int>>(_wordFrequency);
                sortedWords.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
                var topWords = new List<KeyValuePair<string, int>>();
                for (int i = 0; i < Math.Min(10, sortedWords.Count); i++)
                {
                    topWords.Add(sortedWords[i]);
                }

                // Вывод результатов
                Console.WriteLine("Топ 10 самых часто встречающихся слов:");
                foreach (var pair in topWords)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Произошла ошибка при чтении файла: {e.Message}");
            }
        }
    }
}
