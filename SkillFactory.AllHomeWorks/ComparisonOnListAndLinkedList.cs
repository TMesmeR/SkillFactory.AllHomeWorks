using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13._6._1
{
    internal class ComparisonOnListAndLinkedList
    {
        private List<string> list;
        private LinkedList<string> linkedList;
        private ArraySegment<string> words;

        public ComparisonOnListAndLinkedList(string filePath)
        {
            string text = File.ReadAllTextAsync(filePath).Result;
            var wordList = text.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            this.words = new ArraySegment<string>(wordList);
            list = new List<string>(wordList.Length);
            linkedList = new LinkedList<string>(wordList);
        }

        public void TestInsertion()
        {
            Console.WriteLine("Тестирование вставки в List<string> и LinkedList<string>");

            TestInsertion("в конец", (col, word) => col.Add(word), (col, word) => col.AddLast(word));
            TestInsertion("в начало", (col, word) => col.Insert(0, word), (col, word) => col.AddFirst(word));
            TestInsertion("в середину",
                (col, word) => col.Insert(col.Count / 2, word),
                (col, word) => {
                    var middle = GetMiddleNode(col);
                    if (middle != null)
                    {
                        col.AddBefore(middle, word);
                    }
                });
        }

        private void TestInsertion(string description, Action<List<string>, string> listAction, Action<LinkedList<string>, string> linkedListAction)
        {
            Stopwatch stopwatch = new Stopwatch();

            // Вставка в List<string>
            list.Clear();
            stopwatch.Start();
            Parallel.ForEach(words, word => listAction(list, word));
            stopwatch.Stop();
            Console.WriteLine($"Вставка {description} в List<string> заняла: {stopwatch.ElapsedMilliseconds} мс");

            // Вставка в LinkedList<string>
            linkedList.Clear();
            stopwatch.Restart();
            Parallel.ForEach(words, word =>
            {
                var middleNode = GetMiddleNode(linkedList);
                if (middleNode != null)
                {
                    linkedListAction(linkedList, word);
                }
            });
            stopwatch.Stop();
            Console.WriteLine($"Вставка {description} в LinkedList<string> заняла: {stopwatch.ElapsedMilliseconds} мс");
        }

        private LinkedListNode<string> GetMiddleNode(LinkedList<string> linkedList)
        {
            if (linkedList.Count < 2)
                return null;

            var middle = linkedList.First;
            int steps = linkedList.Count / 2;
            for (int i = 0; i < steps; i++)
            {
                middle = middle.Next;
            }
            return middle;
        }
    }
}
