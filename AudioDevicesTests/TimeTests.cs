using Microsoft.VisualStudio.TestTools.UnitTesting;
using AudioDevices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AudioDevices.Tests
{
    [TestClass()]
    public class TimeTests
    {
        [TestMethod()]
        public void TimeTest()
        {
            Time t = new Time(15);
            Assert.AreEqual("00:00:15", t.ToString());
             t = new Time(150);
            Assert.AreEqual("00:02:30", t.ToString());
        }
        [TestMethod()]
        public void TimeTest2()
        {
            Time t = new Time(15,15);
            Assert.AreEqual("00:15:15", t.ToString());
            t = new Time(150,150);
            Assert.AreEqual("02:32:30", t.ToString());
        }
        [TestMethod()]
        public void TimeTest3()
        {
            Time t = new Time(2, 15, 15);
            Assert.AreEqual("02:15:15", t.ToString());
            t = new Time(2, 50, 150);
            Assert.AreEqual("02:52:30", t.ToString());
        }
    }
}