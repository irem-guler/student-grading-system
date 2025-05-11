using Student_Grading_System;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int studentCount = Convert.ToInt32(Console.ReadLine());

        Student[] students = new Student[studentCount];
        double totalAverage = 0;
        double highestAverage = 0;
        string topStudent = "";

        for (int i = 0; i < studentCount; i++)
        {
            students[i] = new Student();

            Console.WriteLine($"\nEnter information for student {i + 1}:");
            Console.Write("First Name: ");
            students[i].FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            students[i].LastName = Console.ReadLine();

            Console.Write("Grade 1: ");
            students[i].Grade1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Grade 2: ");
            students[i].Grade2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Grade 3: ");
            students[i].Grade3 = Convert.ToDouble(Console.ReadLine());

            double avg = students[i].GetAverage();
            students[i].PrintInfo();
            totalAverage += avg;

            if (avg > highestAverage)
            {
                highestAverage = avg;
                topStudent = students[i].FirstName + " " + students[i].LastName;
            }
        }

        Console.WriteLine($"\n Overall Average: {totalAverage / studentCount:F2}");
        Console.WriteLine($" Top Student: {topStudent} ({highestAverage:F2})");

        Console.ReadLine();
    }
}

