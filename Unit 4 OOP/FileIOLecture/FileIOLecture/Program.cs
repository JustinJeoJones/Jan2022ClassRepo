//StreamWriter writer = new StreamWriter("file1.txt", append: true);

//filepath
using FileIOLecture;

string filepath = "../../../Items.txt";

// writing to a file
StreamWriter writer = new StreamWriter(filepath);
writer.WriteLine("Word 1");
writer.WriteLine("Word 2");
writer.WriteLine("Line 3");
writer.Close();

//reading from a file
StreamReader reader = new StreamReader(filepath);
while (true)
{
    string Line = reader.ReadLine();
    if(Line == null)
    {
        break;
    }
    else
    {
        Console.WriteLine(Line);
    }
}

//---------------------------------------------------------------------
//classroom exercise
string classFilePath = "../../../Classroom.txt";

//if file doesn't exist, create a new one
if(File.Exists(classFilePath) == false)
{
    //file doesn't exist. creating new one
    //new student list 
    List<Student> tempStudents = new List<Student>()
    {
        new Student("Justin", 24,3),
        new Student("Josh", 18, 12),
        new Student("Carmen", 17, 12)
    };

    StreamWriter tempClassWriter = new StreamWriter(classFilePath);

    //Write temp students into file
    foreach(Student stu in tempStudents)
    {
        tempClassWriter.WriteLine($"{stu.Name}/{stu.Age}/{stu.Grade}");
    }
    //Save file
    tempClassWriter.Close();
}

//Grab all students and save them
List<Student> Classroom = new List<Student>();

StreamReader ClassReader = new StreamReader(classFilePath);

while (true)
{
    string Line = ClassReader.ReadLine();
    if(Line == null)
    {
        break;
    }
    else
    {
        //Console.WriteLine(Line);
        string[] values = Line.Split("/");
        string name = values[0];
        int age = int.Parse(values[1]);
        int grade = int.Parse(values[2]);
        Student newStudent = new Student(name, age, grade);
        Classroom.Add(newStudent);
    }
}

ClassReader.Close();

//RUN THE PROGRAM
//PRETEND THIS IS OUR MAIN CODE
foreach(Student student in Classroom)
{
    Console.WriteLine($"Name:{student.Name} Age:{student.Age} Grade:{student.Grade}");
}

//PRETEND THEY CHOSE ADD STUDENT
Console.WriteLine("What is the students name?");
string newname = Console.ReadLine();
Console.WriteLine("What is the students age?");
int newage = int.Parse(Console.ReadLine());
Console.WriteLine("What is the students Grade?");
int newgrade = int.Parse(Console.ReadLine());

Student newerStudent = new Student(newname, newage, newgrade);
Classroom.Add(newerStudent);


//PRETEND THEY CHOSE QUIT
//ANY CHANGES TO THE LIST SHOULD UPDATE THE FILE
StreamWriter ClassWriter = new StreamWriter(classFilePath);

foreach(Student student in Classroom)
{
    ClassWriter.WriteLine($"{student.Name}/{student.Age}/{student.Grade}");
}

ClassWriter.Close();