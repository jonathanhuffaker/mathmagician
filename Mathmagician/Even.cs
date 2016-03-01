using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Even : Integer


    {
        [TestMethod]
        public void EvenEnsureICanCreateInstance()

        {
           
            Even my_evens = new Even();
            Assert.IsNotNull(my_evens);
            
        }

        [TestMethod]
        public void EvenEnsureICanGetFirst()
        {
            //arrange

            Even my_evens = new Even();

        }      

    }
}
