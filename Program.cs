

class Student
{
    public string Name;
    public int Age;
    public int Marks;

    public void GetGrade()
    {
        string grade = Marks switch
        {
            >= 90 => "A",
            >= 75 => "B",
            >= 50 => "C",
            _ => "Fail"
        };

        Console.WriteLine("Grade: " + grade);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Student s = new Student();

            Console.WriteLine("\nEnter details for Student " + i);

            Console.Write("Enter Student Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            s.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Marks: ");
            s.Marks = int.Parse(Console.ReadLine());

            Console.WriteLine("\nStudent Name: " + s.Name);
            Console.WriteLine("Age: " + s.Age);
            Console.WriteLine("Marks: " + s.Marks);

            s.GetGrade();
        }
    }
}
