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
    public class MemoRecorderTests
    {
        [TestMethod()]
        public void DisplayStorageCapacityTest()
        {
            MemoRecorder mrTest = new MemoRecorder();
            mrTest.MaxCartridgeType = MemoRecorder.MemoCartRidgeType.c120;
            Assert.AreEqual("Max capacity 120 min.", mrTest.DisplayStorageCapacity());

            MemoRecorder mrTest1 = new MemoRecorder();
            mrTest1.MaxCartridgeType = MemoRecorder.MemoCartRidgeType.anders;
            Assert.AreEqual("Max capacity unknown", mrTest1.DisplayStorageCapacity());

            MemoRecorder mrTest2 = new MemoRecorder();
            mrTest2.MaxCartridgeType = MemoRecorder.MemoCartRidgeType.c90;
            Assert.AreEqual("Max capacity 90 min.", mrTest2.DisplayStorageCapacity());

            MemoRecorder mrTest3 = new MemoRecorder();
            mrTest3.MaxCartridgeType = MemoRecorder.MemoCartRidgeType.c60;
            Assert.AreEqual("Max capacity 60 min.", mrTest3.DisplayStorageCapacity());

            MemoRecorder mrTest4 = new MemoRecorder();
            Assert.AreEqual("Max capacity 60 min.", mrTest4.DisplayStorageCapacity());
        }
    }
}