using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    public class Items
    {
        public int x;
        public int v;
        public int w;

        public Items(int x, int v, int w)
        {
            this.x = x;
            this.v = v;
            this.w = w;
        }
    }
    
    public class Problem
    {
        public List<Items> numbers;

        public Problem(int n, int seed)
        {
            Random r = new Random(seed);
            numbers = new List<Items>(n);
            for (int i = 0; i < n; i++)
            {
                numbers.Add(new Items(i,r.Next(15) + 1, r.Next(15) + 1));
            }
        }

        public int[] Solver(int capacity, int n)
        {
            int value = 0;
            int weight = 0;
            int index = 0;
            int[] array = new int[n+2];
         
            for (int i = 0; i < n ; i++)
            {
                value += numbers[index].v;
                weight += numbers[index].w;
                if (weight <= capacity)
                {
                    Console.WriteLine(index);
                    array[i] = index;
                    numbers[index].x = index;
                }
                else
                {
                    weight = weight - numbers[index].w;
                    value -= numbers[index].v;
                    array[i] = -1;
                }
                index++;
            }

            array[n] = weight;
            array[n + 1] = value;
            Console.WriteLine(Environment.NewLine + "Final weight:");
            Console.WriteLine(weight);
            Console.WriteLine(Environment.NewLine + "Final value:");
            Console.WriteLine(value);
            return array;
        }

        public override string ToString()
        {
            string instance = "";

            numbers.ForEach(item =>{instance += "nr:" + item.x + " v:" + item.v + "  w:" + item.w + Environment.NewLine;});
            return instance;
        }

    }
}
 
