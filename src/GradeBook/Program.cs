using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Keith's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var grades = new List<double>() {12.7, 17.5, 15.9,};
            grades.Add(56.1);
        
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var number in grades)
            {
                
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            result /= grades.Count;      
            System.Console.WriteLine($"The lowest grade is {lowGrade}");
            System.Console.WriteLine($"The Highest grade is {highGrade}"); 
            System.Console.WriteLine($"The average grade is {result:N1}");

        }
    }
}
