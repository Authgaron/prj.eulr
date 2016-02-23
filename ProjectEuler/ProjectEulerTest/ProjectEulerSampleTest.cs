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
            TestHelper.TimedTest<long, Problem1>(10, 23);
        }

        [TestMethod]
        public void Problem2Test()
        {
            TestHelper.TimedTest<long, Problem2>(100, 44);
        }

        [TestMethod]
        public void Problem3Test()
        {
            TestHelper.TimedTest<long, Problem3>(13195, 29);
        }

        [TestMethod]
        public void Problem4Test()
        {
            TestHelper.TimedTest<long, Problem4>(2, 9009);
        }
    }
}
