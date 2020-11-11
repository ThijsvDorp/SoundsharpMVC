using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AudioDevices.Devices.MemoRecorder;

namespace AudioDevices.Devices
{
    class CdDiscMan : AudioDevice
    {
        public override string DisplayStorageCapacity()
        {
            throw new NotImplementedException("Not done yet");
        }
        private readonly int mBSize;
        private int displayWidth;
        private int displayHeight;
        private bool isEjected = false;
    }
}
