using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AudioDevices.Devices;
using SoundsharpMVC;
using static AudioDevices.Devices.MemoRecorder;

namespace SoundsharpMVC.Models
{
    public class VMMemorecorder
    {
        [Key]
       public int SerialId { get; set; }
       public string Make { get; set; }
       public string Model { get; set; }
       public decimal PriceExBtw { get; set; }
       public DateTime CreationDate { get; set; }
       public MemoCartRidgeType MemoCartridgeType { get; set; }
    }
}