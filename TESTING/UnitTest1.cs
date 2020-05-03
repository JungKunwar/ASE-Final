using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Graphical_Programming_Language_Application;
using System.Drawing;

namespace TESTING
{
    [TestClass]
    public class UnitTest1
    {
        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;
        [TestMethod]
        public void TestMethod1()
        {
           var r = new Graphical_Programming_Language_Application.Rectangle();
            int x = 50, y = 50, size = 20, size1 = 20;
            r.set(texturestyle, bb, c1, x, y, size, size1);

        }
    }
}
