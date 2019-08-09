using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x = 35.1; Test Data
            //var y = 25.7; Test Data
            //var result = x + y; Test Data
            //var numbers = new[] {12.7, 17.5, 15.9,}; // array Test Data
            var grades = new List<double>() {12.7, 17.5, 15.9,};
            grades.Add(56.1);
        
            /* numbers[0] = 12.7;
            numbers[1] = 17.5;
            numbers[2] = 15.9; */
            // var arrayresult = numbers[0] + numbers[1] + numbers[2];
            var gradesresult = 0.0;
            foreach (var number in grades)
            {
                gradesresult += number;
            }
            gradesresult /= grades.Count;       
            System.Console.WriteLine($"The average grade is {gradesresult:N1}");

            /* Foreach loop testing
                var arrayresult = 0.0;
            foreach (var number in numbers)
            {
              arrayresult += number;               
            }
            Console.WriteLine($"{arrayresult}");  
             */   
            //Console.WriteLine($"{numbers[0]} + {numbers[1]} + {numbers[2]} = {arrayresult}");
            //Console.WriteLine($"{x} + {y} = {result}");

            if(args.Length > 0)
            {
            Console.WriteLine($"Hello, {args[0]} !");
            }
            else
            {
                Console.WriteLine("Hello Now!");
            }    
        }
    }
}
