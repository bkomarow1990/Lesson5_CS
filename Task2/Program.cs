using System;
using System.Collections.Generic;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mark> marks = new List<Mark> { new Mark(new DateTime(2021, 3, 12), 12), new Mark(new DateTime(2021, 4, 2), 11), new Mark(new DateTime(2021, 5, 23), 10) } ;
            Student student = new Student(marks, "Eugene" );
            Console.WriteLine(student.ToString());
            Console.WriteLine($"Average mark: {student.getAverageMark()}");
            student.CancelMark(1);
            Console.WriteLine("Canceled mark:");
            Console.WriteLine(student.ToString());
            Console.WriteLine($"Average mark: {student.getAverageMark()}");
        }
    }
}
