using Module13._6._2;

string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Text1.txt");

var analyzer = new WordFrequencyAnalyzer(filePath);
analyzer.Analyze();