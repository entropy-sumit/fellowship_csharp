using Microsoft.VisualStudio.TestTools.UnitTesting;
using MStestRegetration;
using TestingValidRegistration;

namespace TestingValidRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            RegistrationClass registrationClass = new RegistrationClass();
                string firstname = "Sumit";
                string lastname = "Rawat";
                string expected = "Sumit Rawat";
                string actual;

                //act
                actual = registrationClass.GETName(firstname, lastname);

                //assert
                Assert.AreEqual(expected, actual);
            
        }
    }
}
