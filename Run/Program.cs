using System;
using StudentClass;

namespace Run
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Active
            Student student = new Student(1234, "Jens", "Jensen", DateTime.Today.AddDays(-100), DateTime.Today.AddDays(200), DateTime.Today.AddDays(95));
            Console.WriteLine(student.ToString());

            //Dropout
            Student student1 = new Student(3333, "Bob", "Bobsen", DateTime.Today.AddDays(-100), DateTime.Today, DateTime.Today.AddDays(40));
            Console.WriteLine(student1.ToString());

            //New
            Student student2 = new Student(444, "Alice", "Alicen", DateTime.Today.AddDays(-5), DateTime.Today.AddDays(100), DateTime.Today.AddDays(40));
            Console.WriteLine(student2.ToString());

            //Graduated
            Student student3 = new Student(5555, "Lars", "Larsen", DateTime.Today.AddDays(-100), DateTime.Today, DateTime.Today.AddDays(-5));
            Console.WriteLine(student3.ToString());

            student3.StartDate = DateTime.Now;
            Console.WriteLine(student3.StartDate);
        }
    }
}
