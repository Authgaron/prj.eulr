using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;

namespace ProjectEulerTest
{
    [TestClass]
    public class ProjectEulerAnswerTest
    {
        [TestMethod]
        public void Problem1Test()
        {
            TestHelper.TimedTest<long, Problem1>(1000, 233168);
        }

        [TestMethod]
        public void Problem2Test()
        {
            TestHelper.TimedTest<long, Problem2>(4000000, 4613732);
        }

        [TestMethod]
        public void Problem3Test()
        {
            TestHelper.TimedTest<long, Problem3>(600851475143, 6857);
        }

        [TestMethod]
        public void Problem4Test()
        {
            TestHelper.TimedTest<long, Problem4>(3, 906609);
        }
    }
}
