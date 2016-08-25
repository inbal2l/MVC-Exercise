using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using WebApplication7.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebApplication7.Controllers.Tests
{
    [TestClass()]
    public class Feature1ControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            var controller = new Feature1Controller();
            Assert.IsNotNull(controller, "The controller is null");
        }
    }
}