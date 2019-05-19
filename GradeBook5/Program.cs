using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook5
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Frank's Grade Book.");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();
           
            Console.WriteLine($"The lowest grade recorded was {stats.Low}.");
            Console.WriteLine($"The highest greade recorder was {stats.High}.");
            Console.WriteLine($"The average grade is {stats.Average:N1}.");



            /*if (args.Length > 0)
            {
               
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Just Hello");
            }*/

            Console.ReadLine();
        }
    }
}
