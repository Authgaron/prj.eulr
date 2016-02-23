using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem1 : IProblem<long>
    {
        public long Solve(long input)
        {
            long sum = 0;
            for (long i = 0; i < input; i++)
            {
                sum += (i % 5 == 0 || i % 3 == 0) ? i : 0;
            }
            return sum;
        }
    }
}
