Проект разделен на ветки под различными модулями (ДЗ). 

Модуль 15. LINQ

Есть список учеников школы с разбивкой по классам:

    class Program
    {
        static void Main(string[] args)
        {
            var classes = new []
            {
                new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
                new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
                new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);
          
            Console.WriteLine(string.Join(" ", allStudents));
        }
  
        static string [] GetAllStudents( Classroom [] classes )
        {
            // ???
        }
       
        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }

Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.
