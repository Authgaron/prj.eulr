using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperClasses;

namespace ProjectEuler
{
    public class Problem4 : IProblem<long>
    {
        public long Solve(long input)
        {
            long lower = (long)Math.Pow(10, input-1);
            long upper = lower * 10;
            long max = lower * lower;

            for (long i = lower; i < upper; i++)
            {
                for (long j = lower; j < upper; j++)
                {
                    if (i * j > max)
                    {
                        string original = (i * j).ToString();
                        string reversed = "";
                        for (int c = original.Length - 1; c >= 0; c--)
                        {
                            reversed += original[c];
                        }
                        if (reversed.Equals(original))
                        {
                            max = i * j;
                        }
                    }
                }
            }
            return max;
        }
    }
}
