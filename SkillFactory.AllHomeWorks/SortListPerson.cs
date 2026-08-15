using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module._9._6._1
{
    internal class SortListPerson
    {
        public delegate void SortingHandler(List<string> items, bool ascending);
        public static event SortingHandler SortEvent;
        public SortListPerson(SortingHandler sortingHandler)
        {
            SortEvent += sortingHandler;
        }

        public void StartProgram(List<string> items)
        {
            Console.WriteLine("Получен список имен:");

            foreach (var item in items)
            {

                Console.WriteLine(item);

            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Введите 1 для сортировки А-Я или 2 для сортировки Я-А:");
                string input = Console.ReadLine();

                try
                {
                    int sortOption = int.Parse(input);
                    if (sortOption != 1 && sortOption != 2)
                    {
                        throw new myException("Номер опции должен быть 1 или 2.");
                    }

                    SortEvent.Invoke(items, sortOption == 1);

                    foreach (var name in items)
                    {

                        Console.WriteLine(name);
                    }

                }

                catch (myException ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}
