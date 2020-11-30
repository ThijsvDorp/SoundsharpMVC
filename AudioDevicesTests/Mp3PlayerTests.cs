using Microsoft.VisualStudio.TestTools.UnitTesting;
using AudioDevices.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Devices;

namespace AudioDevices.Devices.Tests
{
    [TestClass()]
    public class Mp3PlayerTests
    {
        [TestMethod()]
        public void DisplayStorageCapacityTest()
        {
            Mp3Player Playertest1 = new Mp3Player();
            Playertest1.MbSize = 100;
            Assert.AreEqual("100 mB.", Playertest1.DisplayStorageCapacity());
            Mp3Player Playertest2 = new Mp3Player();
            Playertest2.MbSize = 0;
            Assert.AreEqual("Storage capacity unknown", Playertest2.DisplayStorageCapacity());
        }

        [TestMethod()]
        public void GetResolutionInfoTest()
        {
            Mp3Player Resolutiontest1 = new Mp3Player();
            Resolutiontest1.DisplayHeight = 5;
            Resolutiontest1.DisplayWidth = 5;
            Assert.AreEqual("Resolution: 25 pixels", Resolutiontest1.GetResolutionInfo());
            Mp3Player Resolutiontest2 = new Mp3Player();
            Resolutiontest2.DisplayHeight = 10;
            Resolutiontest2.DisplayWidth = 10;
            Assert.AreEqual("Resolution: 100 pixels", Resolutiontest2.GetResolutionInfo());
        }
    }
}