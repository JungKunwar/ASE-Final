using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Graphical_Programming_Language_Application;
using System.Drawing;

namespace TESTING
{
    [TestClass]
    public class RectangleTesting
    {
        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;
         
        public RectangleTesting() 
        {

        }


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
           var r = new Graphical_Programming_Language_Application.Rectangle();
            int x = 50, y = 50, size = 20, size1 = 20;
            r.set(texturestyle, bb, c1, x, y, size, size1);
            Assert.AreEqual(50, r.x);  

        }
    }
}
