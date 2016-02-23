using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void IntegerEnsureICanCreateAnInstance()
        {
            Integer my_int = new Integer();
            Assert.IsNotNull(my_int);
        }
        [TestMethod]
        public void IntegerEnsureICanGetFirstNumber()
        {
            //Arrange - this is where you set up scenario
            Integer my_int = new Integer();

            //Act - the the thing you want to test
            int actual = my_int.GetFirst();
            int expected = 0;

            //Assert - did it work as expected?
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void IntegerEnsureICanGetNextInteger()
        {
            //Arrange
            Integer my_int = new Integer();

            //Act 
            int actual = my_int.GetNext(5);
            int expected = 6;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void IntegerEnsureICanCreateASequenceofTenIntegers()
        
        {
        //arrange
        Integer my_int = new Integer();

        //Act
        int[] actual = my_int.GetSequence(10);
        int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IntegerEnsureMaxIsNotExceeded()
        {

            //arrange
            Integer my_int = new Integer();
           

            //Act
            int[] actual = my_int.GetSequence(my_int.Max +1 );
           //This is a call the uses an older testing framework. (e
            //Assert.Throws(typeof(Exception), my_int.GetSequence(my_int.Max));
        }
     
    }
}
