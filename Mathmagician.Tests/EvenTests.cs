using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EvenEnsureICanCreateInstance()
        {
            Even my_evens = new Even();
            Assert.IsNotNull(my_evens);

          
        }

        [TestMethod]
        public void EvenEnsureICanGet Next()
        {
            //arrange
            EventArgs my_evens = new Even();

            //Act
            int actual -my_evens.GetNext(6);
            int expected = 8;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
