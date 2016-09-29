using Microsoft.VisualStudio.TestTools.UnitTesting;
using APD.AGL.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD.AGL.UnitTests
{
    [TestClass()]
    public class PeopleServicesTests
    {
        [TestMethod()]
        public void LoadDataTest()
        {
            var service = new PeopleServices();
            Assert.IsTrue(service.Peoples.Count() == 6);
        }

        [TestMethod()]
        public void GetCatByGenderTest()
        {
            var service = new PeopleServices();
            var cats = service.GetCatByGender("Male");
            foreach(var cat in cats)
            {
                Assert.IsTrue(cat.Type.Equals("Cat"));
            }
            Assert.AreEqual(2, cats.Count);
        }
    }
}