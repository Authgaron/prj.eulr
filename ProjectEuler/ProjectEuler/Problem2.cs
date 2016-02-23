using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperClasses;

namespace ProjectEuler
{
    public class Problem2 : IProblem<long>
    {
        public long Solve(long input)
        {
            List<long> fibonacci = Fibonacci.Below(input).FindAll(n => n % 2 == 0);
            long sum = 0;

            foreach (long x in fibonacci)
            {
                sum += x;
            }

            return sum;
        }
    }
}
