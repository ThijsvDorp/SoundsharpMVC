using Microsoft.VisualStudio.TestTools.UnitTesting;
using AudioDevices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AudioDevices.Tests
{
    [TestClass()]
    public class TrackTests
    {
        [TestMethod()]
        public void TrackTest()
        {
            Tracks t1 = new Tracks(1, "Coldplay","Yellow");

            Assert.AreEqual("Yellow", t1.Name);
            Assert.AreEqual("Coldplay", t1.Artist);
            Assert.AreEqual(1, t1.Id);

        }
        [TestMethod()]
        public void TrackTest2()
        {
            Tracks t2 = new Tracks
            {
                Name = "Shiver",
                Artist = "Coldplay",
                AlbumSource = "Parachutes",
                Length = new AudioDevices.Time(0, 4, 59),
                Style = Category.Pop
            };
            Assert.AreEqual("Shiver", t2.Name);
            Assert.AreEqual("Coldplay", t2.Artist);
            Assert.AreEqual("00:04:59", t2.Length.ToString());
            Assert.AreEqual("Parachutes", t2.AlbumSource);
            Assert.AreEqual("Pop", t2.Style.ToString());

        }
    }
}