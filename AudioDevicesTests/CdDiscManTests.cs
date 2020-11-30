using Microsoft.VisualStudio.TestTools.UnitTesting;
using AudioDevices.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices.Tests
{
    [TestClass()]
    public class CdDiscManTests
    {
        [TestMethod()]
        public void EjectTest()
        {
            CdDiscMan discManTest1 = new CdDiscMan();
            discManTest1.Eject();
            Assert.AreEqual(false, discManTest1.IsEjected);
            
            Assert.AreEqual(true,discManTest1.IsEjected);
        }
    }
}