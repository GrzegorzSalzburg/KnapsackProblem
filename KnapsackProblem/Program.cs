using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items:");
            int n =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seed:");
            int seed = int.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);
            Problem problem = new Problem(n, seed);
            Console.WriteLine(problem.ToString());
            Console.WriteLine("Enter the capacity of your backpack:");
            int capacity = int.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);
            problem.Solver(capacity, n);
            Console.ReadLine();
        }
    }
}
