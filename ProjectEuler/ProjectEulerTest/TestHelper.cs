using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using ProjectEuler;

namespace ProjectEulerTest
{
    class TestHelper
    {
        public static void TimedTest<TInput, TProblem>(TInput input, int expected) where TProblem : IProblem<TInput>, new()
        {
            Timer watch = new Timer(60000);
            TProblem problem = new TProblem();
            watch.Elapsed += new ElapsedEventHandler(OnTimeOut);
            long result = problem.Solve(input);
            Assert.AreEqual(expected, result, String.Format("The resulting value is incorrect.\nObtained: {0}\nExpected:{1}", result, expected));
        }

        private static void OnTimeOut(object source, ElapsedEventArgs e)
        {
            Assert.Fail("Timed out - 1 minute.");
        }
    }
}
