using AssertAll.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssertAll.Tests.AssertAllTests
{
    [TestClass]
    public class FailShould : TestBase
    {
        [TestMethod]
        public void Fail()
        {
            AssertAll.Fail();

            Assert.ThrowsException<AssertAllFailedException>(() => AssertAll.Execute());
        }
    }
}