using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    class Student
    {
        private string firstName;
        private string lastName;
        private double grade1, grade2, grade3;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value.ToUpper(); }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value.ToUpper(); }
        }

        public double Grade1
        {
            get { return grade1; }
            set { grade1 = Math.Abs(value); }
        }

        public double Grade2
        {
            get { return grade2; }
            set { grade2 = Math.Abs(value); }
        }

        public double Grade3
        {
            get { return grade3; }
            set { grade3 = Math.Abs(value); }
        }

        public double GetAverage()
        {
            return (grade1 + grade2 + grade3) / 3.0;
        }

        public void PrintInfo()
        {
            double avg = GetAverage();
            Console.WriteLine("\nFirst Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Average: " + avg);

            if (avg >= 90)
                Console.WriteLine("Status: Honor Certificate ");
            else if (avg >= 60)
                Console.WriteLine("Status: Passed ");
            else if (avg >= 50)
                Console.WriteLine("Status: Conditional Pass ");
            else
                Console.WriteLine("Status: Failed ");
        }
    }

}
