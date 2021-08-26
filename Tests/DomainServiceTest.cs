namespace Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Domain;
    
    [TestClass]
    public class DomainServiceTest
    {
        private bool result = false;

        private DomainService serviceUnderTest;

        [TestInitialize]
        public void SetUp()
        {
            this.serviceUnderTest = new DomainService();
            this.result = this.serviceUnderTest.Test();
        }

        [TestMethod]
        public void TestMethod()
        {
            Assert.IsTrue(this.result);
        }

        [TestCleanup]
        public void Cleanup()
        {
            this.result = false;
        }
    }
}
