using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.Models.Tests
{
    [TestClass()]
    public class ClassNameTests
    {
        [TestMethod()]
        public void GetTextFromPageTest()
        {
            ClassName NewClass = new ClassName();
            bool isTextFromPage = NewClass.GetTextFromPage();
            Assert.IsTrue(isTextFromPage, "The function has faild");
            Assert.IsNotNull(NewClass.ResponseString, "The responce is null");
        }
    }
}