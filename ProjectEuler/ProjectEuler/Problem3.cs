using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperClasses;

namespace ProjectEuler
{
    public class Problem3 : IProblem<long>
    {
        public long Solve(long input)
        {
            long value = input;
            long current = 1;

            while (value > 1)
            {
                current++;
                while (value % current ==0)
                {
                    value /= current;
                }
            }
            return current;
        }
    }
}
