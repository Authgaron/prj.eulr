using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperClasses;

namespace ProjectEuler
{
    public class Problem2 : IProblem<int>
    {
        public int Solve(int input)
        {
            List<int> fibonacci = Fibonacci.Below(input).FindAll(n => n % 2 == 0);
            int sum = 0;

            foreach (int x in fibonacci)
            {
                sum += x;
            }

            return sum;
        }
    }
}
