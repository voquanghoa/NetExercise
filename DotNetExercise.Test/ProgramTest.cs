using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetExercise.Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual(Program.Sum(8, 6), 14);
        }

        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual(Program.Sub(8, 6), 2);
        }
    }
}
