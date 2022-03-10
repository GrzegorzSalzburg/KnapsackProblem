using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    public class Items
    {
        public int v;
        public int w;

        public Items(int v, int w)
        {
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
                numbers.Add(new Items(r.Next(29) + 1, r.Next(29) + 1));
            }
        }

        public object solve(int capacity)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string str = string.Join(" ", numbers.ToArray());
            return str;
        }


    }
}
 
