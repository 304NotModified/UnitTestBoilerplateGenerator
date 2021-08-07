using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitBoilerplate.Sandbox.Classes;
using UnitBoilerplate.Sandbox.Classes.Cases;

namespace UnitTestBoilerplate.SelfTest.Cases
{
    [TestClass]
    public class PropertyInjectedClassSingleTests
    {
        private MockRepository mockRepository;

        private Mock<ISomeInterface> mockSomeInterface;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockSomeInterface = this.mockRepository.Create<ISomeInterface>();
        }

        private PropertyInjectedClassSingle CreatePropertyInjectedClassSingle()
        {
            return new PropertyInjectedClassSingle
            {
                MyProperty = this.mockSomeInterface.Object,
            };
        }

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var propertyInjectedClassSingle = this.CreatePropertyInjectedClassSingle();

            // Act


            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }
    }
}
