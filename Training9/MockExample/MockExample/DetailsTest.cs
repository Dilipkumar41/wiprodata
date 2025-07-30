using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;

namespace MockExample
{
    [TestFixture]
    internal class DetailsTest
    {
        [Test]
        public void TestShowStudent()
        {
            Mock<IDetails> mockDetails = new Mock<IDetails>();
            mockDetails.Setup(d => d.ShowStudents()).Returns("Hi I am Kusuma...");
            Assert.AreEqual("Hi I am Kusuma...", mockDetails.Object.ShowStudents());
        }

        [Test]
        public void TestShowCompany()
        {
            Mock<IDetails> obj = new Mock<IDetails>();
            obj.Setup(x => x.ShowCompany()).Returns("Its from Wipro Bangalore...");
            Assert.AreEqual("Its from Wipro Bangalore...", obj.Object.ShowCompany());
            //Details obj  = new Details();
            //Assert.AreEqual("Its from Wipro Chennai...",obj.ShowCompany());
        }
    }
}
