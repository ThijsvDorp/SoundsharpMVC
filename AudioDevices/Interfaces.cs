using AudioDevices.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Interfaces
{
    class Interfaces
    {
        interface IDisplay
        {
            string GetResolutionInfo();
            int DisplayWidth { get; set; }
            int DisplayHeight { get; set; }
            int TotalPixels { get; }
        }
    }
}
