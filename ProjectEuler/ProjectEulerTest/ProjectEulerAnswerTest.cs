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
            TestHelper.TimedTest<int, Problem1>(1000, 233168);
        }

        [TestMethod]
        public void Problem2Test()
        {
            TestHelper.TimedTest<int, Problem2>(4000000, 4613732);
        }
    }
}
