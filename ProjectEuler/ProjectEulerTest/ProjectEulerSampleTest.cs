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
    }
}
