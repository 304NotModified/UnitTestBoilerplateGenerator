using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitBoilerplate.Sandbox.Classes;
using UnitBoilerplate.Sandbox.Classes.Cases;

namespace UnitTestBoilerplate.SelfTest.Cases
{
    [TestClass]
    public class ConstructorInjectedClassSingleTests
    {
        private MockRepository mockRepository;

        private Mock<ISomeInterface> mockSomeInterface;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockSomeInterface = this.mockRepository.Create<ISomeInterface>();
        }

        private ConstructorInjectedClassSingle CreateConstructorInjectedClassSingle()
        {
            return new ConstructorInjectedClassSingle(
                this.mockSomeInterface.Object);
        }

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var constructorInjectedClassSingle = this.CreateConstructorInjectedClassSingle();

            // Act


            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }
    }
}
