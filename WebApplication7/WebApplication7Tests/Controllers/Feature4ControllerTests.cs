using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication7.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.Controllers.Tests
{
    [TestClass()]
    public class Feature4ControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            var controller = new Feature4Controller();
            Assert.IsNotNull(controller, "The controller is null");
        }
    }
}