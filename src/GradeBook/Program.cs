using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 35.1;
            var y = 25.7;
            var result = x + y;
            var numbers = new[] {12.7, 17.5, 15.9,}; // array
            /* numbers[0] = 12.7;
            numbers[1] = 17.5;
            numbers[2] = 15.9; */
            // var arrayresult = numbers[0] + numbers[1] + numbers[2];
            var arrayresult = 0.0;
            foreach (var number in numbers)
            {
              arrayresult += number;               
            }
            Console.WriteLine($"{arrayresult}");  

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
