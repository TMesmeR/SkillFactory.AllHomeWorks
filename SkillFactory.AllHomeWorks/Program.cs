string inputFile = "SampleDataFile/students.dat";
string outputDirectory =  "Students";

if (!Directory.Exists(outputDirectory))
{
    Directory.CreateDirectory(outputDirectory);
}

List<Student> students = new List<Student>();

using (BinaryReader reader = new BinaryReader(File.Open(inputFile, FileMode.Open)))
{
    while (reader.BaseStream.Position != reader.BaseStream.Length)
    {
        Student student = new Student();
        student.Name = reader.ReadString();
        student.Group = reader.ReadString();
        student.DateOfBirth = DateTime.FromBinary(reader.ReadInt64());
        student.AverageGrade = reader.ReadDecimal();

        students.Add(student);
    }
}

foreach (var student in students)
{
    string groupFile = outputDirectory + "\\" + student.Group + ".txt";

    using (StreamWriter writer = File.AppendText(groupFile))
    {
        writer.WriteLine($"{student.Name}, {student.DateOfBirth}, {student.AverageGrade}");
    }
}

Console.WriteLine("Студенты выгружены. По умолчанию /bin/Debug/net9.0/Folder");
class Student
{
    public string Name { get; set; }
    public string Group { get; set; }
    public DateTime DateOfBirth { get; set; }
    public decimal AverageGrade { get; set; }
}