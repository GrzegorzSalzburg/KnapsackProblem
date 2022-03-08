using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    internal class Result
    {
        public List<int> items;
        public int totalValues;
        public float totalWeights;

        public Result()
        {
            items =new List<int>();
            totalWeights = 0;   
            totalValues = 0;
        }

        public override string ToString()
        {
            string str =string.Empty;
            str += "items: ";
            foreach (var item in items)
                str += item.ToString() + " ";
            str += Environment.NewLine;
            str += "v: " + totalValues;
            str += Environment.NewLine;
            str += "w: " + totalWeights;
            str += Environment.NewLine;
            return str;
        }
    }
}
