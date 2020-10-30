using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    abstract class AudioDevice
    {
        private int serialId;
        private string model;
        private string make;
        private decimal priceExBtw;
        private DateTime creationDate;
        protected readonly static double btwPercentage = 19.0;
        public string DisplayIdentity()
        {
            string text = "Serial: " + serialId;
            return text;
        }
        public string DisplayIdentity(bool makeInfo, bool modelInfo)
        {
            return DisplayIdentity();
        }
    }
}
