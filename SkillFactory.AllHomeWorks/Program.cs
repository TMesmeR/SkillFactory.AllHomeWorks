
using Module._9._6._1;

Task1();
Console.WriteLine();

Task2();



void Task1()
{
    Exception[] exceptions = new Exception[]
    {
    new myException(),
    new DivideByZeroException(),
    new IndexOutOfRangeException(),
    new ArgumentNullException(),
    new ArgumentOutOfRangeException()
    };

    foreach (var ex in exceptions)
    {
        try
        {
            throw ex;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
///-------------------------------------------------------------------///
///-------------------------------------------------------------------///
///-------------------------------------------------------------------///
void Task2()
{

    List<string> names = new List<string>() { "Иванов", "Петров", "Сидоров", "Кузнецов", "Белов" };
    SortListPerson sortListPerson = new SortListPerson(SortNames);
    sortListPerson.StartProgram(names);


    static void SortNames(List<string> items, bool ascending)
    {
        if (ascending)
        {
            items.Sort(); 
        }
        else
        {
            items.Sort((x, y) => y.CompareTo(x));
        }
    }
}

