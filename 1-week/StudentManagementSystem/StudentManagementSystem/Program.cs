public class Program
{
    public static void Main(string[] args)
    {
        PrintMenuStudentManagement();
        Console.WriteLine();
        Console.WriteLine("Enter your choice:");
        int choice = Console.ReadLine() != null ? int.Parse(Console.ReadLine()) : 0;
        while (choice != 7)
        {
            List<Student> students = new List<Student>();
            switch (choice)
            {
                case 1:
                    AddStudent(students);
                    break;
                case 2:
                    RemoveStudent(students);
                    break;
                case 3:
                    FindStudent(students);
                    break;
                case 4:
                    ShowAllStudents(students);
                    break;
                case 5:
                    UpdateStudent(students);
                    break;
                case 6:
                    SortStudents(students);
                    break;
                case 7:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
            PrintMenuStudentManagement();
            choice = Console.ReadLine() != null ? int.Parse(Console.ReadLine()) : 0;
        }

    }


    public static void PrintMenuStudentManagement()
    {
        Console.WriteLine("============Student Management System============");
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. Remove Student");
        Console.WriteLine("3. Find student");
        Console.WriteLine("4. Show all students");
        Console.WriteLine("5. Update student");
        Console.WriteLine("6. Sort students");
        Console.WriteLine("7. Exit");
    }

    public static void AddStudent(List<Student> students)
    {
        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter student age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter student grade:");
        string grade = Console.ReadLine();
        Student student = new Student(name, age, grade);
        students.Add(student);
        Console.WriteLine("Student added successfully!");
    }

    public static void RemoveStudent(List<Student> students)
    {
        Console.WriteLine("Enter student name to remove:");
        string name = Console.ReadLine();
        Student student = students.Find(s => s.Name == name);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("Student removed successfully!");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }

    public static void FindStudent(List<Student> students)
    {
        Console.WriteLine("Enter student name to find:");
        string name = Console.ReadLine();
        Student student = students.Find(s => string.Equals(s.Name, name, StringComparison.OrdinalIgnoreCase));
        if (student != null)
        {
            Console.WriteLine($"Student found: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }

    public static void ShowAllStudents(List<Student> students)
    {
        Console.WriteLine("All students:");
        foreach (Student student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
        }
    }

    public static void UpdateStudent(List<Student> students)
    {
        Console.Write("Enter student id to update: ");
        String id = Console.ReadLine();
        Student student = students.Find(s => s.Id == id);

        if (student != null)
        {
            Console.WriteLine($"Student found: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
        }
        else { Console.WriteLine("Student not found!"); }
    }

    public static void SortStudents(List<Student> students)
    {
        Console.WriteLine("Sort students by:");
        Console.WriteLine("1. Name");
        Console.WriteLine("2. Age");
        Console.WriteLine("3. Grade");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                students.Sort((s1, s2) => string.Compare(s1.Name, s2.Name));
                break;
            case 2:
                students.Sort((s1, s2) => s1.Age.CompareTo(s2.Age));
                break;
            case 3:
                students.Sort((s1, s2) => string.Compare(s1.Grade, s2.Grade));
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}

    public class Student
{
    public String Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}

