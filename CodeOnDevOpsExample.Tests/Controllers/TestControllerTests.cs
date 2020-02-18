using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeOnDevOpsExample.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnDevOpsExample.Controllers.Tests
{
    [TestClass()]
    public class TestControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            int i = 0;
            Assert.AreEqual(1, i);
        }
    }
}