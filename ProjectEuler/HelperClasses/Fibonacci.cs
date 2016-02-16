using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperClasses
{
    public class Fibonacci
    {
        public static List<int> Below(int input)
        {
            List<int> result = new List<int>();
            int next = 1;
            int last = 1;
            while (next < input)
            {
                next = next + last;
                last = next - last;
                result.Add(last);
            }
            return result;
        }
    }
}
