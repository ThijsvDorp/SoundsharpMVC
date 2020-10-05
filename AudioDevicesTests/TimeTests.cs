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
        }
    }
}