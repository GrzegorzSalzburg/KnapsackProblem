using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    public class Problem
    {
        public List<int> numbers;

        public Problem(int n, int seed)
        {
            Random r = new Random(seed);
            numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add(r.Next(50));
            }
        }

        public override string ToString()
        {
            string str = string.Join(" ", numbers.ToArray());
            return str;
        }

        internal object run(int capacity)
        {
            throw new NotImplementedException();
        }
    }
}
 
