using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem1 : IProblem<int>
    {
        public int Solve(int input)
        {
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                sum += (i % 5 == 0 || i % 3 == 0) ? i : 0;
            }
            return sum;
        }
    }
}
