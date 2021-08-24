namespace Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Domain;

    [TestClass]
    public class DomainServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var Sut = new DomainService();
            Assert.IsTrue(Sut.Test());
        }
    }
}
