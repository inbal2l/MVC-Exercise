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
    public class ClassCloudTests
    {
        // I've condiserd creating ONE cloud instanse, but internet said not to because it leads to a fall through
        // errors.
        [TestMethod()]
        public void InitializeCloudTest()
        {
            ClassCloud NewCloud = new ClassCloud();
            bool isInitialized = NewCloud.InitializeCloud();
            Assert.IsNotNull(NewCloud.CloudArr, "The cloud arr was not set");
            Assert.AreEqual((double)600, (double)NewCloud.CloudArr.Length, 10, "Cloud length is incorrect");
            Assert.IsTrue(isInitialized, "Cloud was not initialized");
        }

        [TestMethod()]
        public void WeightCloudTest()
        {
            ClassCloud NewCloud = new ClassCloud();
            NewCloud.WeightCloud();
            Assert.IsNotNull(NewCloud.CloudWeighted, "The cloud weighted was not set properly");
        }

        [TestMethod()]
        public void GetCloudClassesTest()
        {
            ClassCloud NewCloud = new ClassCloud();
            NewCloud.InitializeCloud();
            for (int i = 0; i < NewCloud.CloudArr.Length; i++)
            {
                string GetCloudClassesReturn = NewCloud.GetCloudClasses(NewCloud.CloudArr[i]);
                Assert.IsNotNull(GetCloudClassesReturn, "No classes was retrived for the word, the string is null");
                Assert.IsTrue(GetCloudClassesReturn.Contains(NewCloud.CloudArr[i]), "The classes was retrived are incorrect");
            }
        }
    }
}