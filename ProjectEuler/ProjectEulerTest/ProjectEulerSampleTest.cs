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
            TestHelper.TimedTest<int, Problem1>(10, 23);
        }

        [TestMethod]
        public void Problem2Test()
        {
            TestHelper.TimedTest<int, Problem2>(100, 44);
        }
    }
}
