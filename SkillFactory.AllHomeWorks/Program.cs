using Module13._6._1;

string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Text1.txt");

var tester = new ComparisonOnListAndLinkedList(filePath);
tester.TestInsertion();


