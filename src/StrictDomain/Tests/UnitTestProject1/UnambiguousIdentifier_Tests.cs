using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practices;

namespace UnitTestProject1
{
    [TestClass]
    public class UnambiguousIdentifier_Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var id = new UnambiguousIdentifier<string>(Guid.NewGuid());
            
            Assert.AreEqual((Guid)id, (Guid)id);
        }
    }
}
