using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TLService;

namespace TLServiceUnitTest
{
    [TestClass]
    public class TLServiceTest
    {
        private TruongLocService _service;

        public TLServiceTest() 
        { 
            _service = new TruongLocService(); 
        }

        [TestMethod]
        public void GetServiceName_Test1()
        {
            string serviceName = _service.GetServiceName();
            Assert.Equals(serviceName, "TruongLocService");
        }

        [TestMethod]
        public void GetServiceName_Test2()
        {
            string serviceName = _service.GetServiceName();
            Assert.AreNotEqual(serviceName, "SomethingService");
        }
    }
}
