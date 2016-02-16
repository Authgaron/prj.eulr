using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;

namespace ProjectEulerTest
{
    [TestClass]
    public class ProjectEulerSampleTest
    {
        [TestMethod]
        public void Problem1Test()
        {
            Problem1 p1 = new Problem1();
            TestHelper.TimedTest<int>(p1.Solve, 10, 23);
        }
    }
}
