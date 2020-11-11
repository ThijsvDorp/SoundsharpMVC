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
    public class AudioDeviceTests
    {
        [TestMethod()]
        public void DisplayIdentityTest()
        {
            MemoRecorder test1 = new MemoRecorder();
            test1.Make = "Test";
            test1.Model = "Test1";
            Assert.AreEqual("Serial: 1 Make: Test", test1.DisplayIdentity(true, false));

            MemoRecorder test2 = new MemoRecorder();
            test2.Make = "Test";
            test2.Model = "Test1";
            Assert.AreEqual("Serial: 2 Model: Test1", test2.DisplayIdentity(false, true));

            MemoRecorder test3 = new MemoRecorder();
            Assert.AreEqual("Serial: 3", test3.DisplayIdentity());

            MemoRecorder test4 = new MemoRecorder();
            Assert.AreEqual("Serial: 4", test4.DisplayIdentity(false, false));

            MemoRecorder test5 = new MemoRecorder();
            test5.Make = "Test";
            test5.Model = "Test5";
            Assert.AreEqual("Serial: 5 Make: Test Model: Test5", test5.DisplayIdentity(true, true));

        }
    }
}