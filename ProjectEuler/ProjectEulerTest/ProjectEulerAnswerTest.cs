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
    }
}
