using AudioDevices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoundsharpMVC.Models
{
    public class VMMp3Player
    {
        [Key]
        public int MbSize { get; set; }
        public int DisplayWidth { get; set; }
        public int DisplayHeight { get; set; }
        public int TotalPixels { get; set; }
        public TrackList TrackList { get; }
        public string Picture { get; set; }
    }
}