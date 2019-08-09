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
            var numbers = new double[3];
            numbers[0] = 12.7;
            numbers[1] = 17.5;
            numbers[2] = 15.9;
            var arrayresult = numbers[0] + numbers[1] + numbers[2];

            Console.WriteLine($"{numbers[0]} + {numbers[1]} + {numbers[2]} = {arrayresult}");
            Console.WriteLine($"{x} + {y} = {result}");

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
