using System;
using Exceptions.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exceptions.Tests
{
    [TestClass]
    public class TriangleTestExceptionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ExamScoreException))]
        public void TestConstructors()
        {
            var e = new TriangleAngles(60, 60, 60);
        }
    }
}
