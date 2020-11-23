using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AudioDevices.Devices;
using SoundsharpMVC;
using static AudioDevices.Devices.CdDiscMan;

namespace SoundsharpMVC.Models
{
    public class VMDiscMan
    {
        [Key]
        public string Make { get; set; }
        public string Model { get; set; }
        public int MbSize { get; set; }
        public int DisplayWidth { get; set; }
        public int DisplayHeight { get; set; }
        public int TotalPixels { get; set; }
        public bool IsEjected { get; set; }
    }
}