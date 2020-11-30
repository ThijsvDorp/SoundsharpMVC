using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AudioDevices.Devices.MemoRecorder;
using AudioDevices;
using static AudioDevices.Interfaces.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace AudioDevices.Devices
{
    public class CdDiscMan : AudioDevice, IDisplay
    {
        private readonly int mBSize = 700;
        private int displayWidth;
        private int displayHeight;
        private bool isEjected = false;
        public CdDiscMan()
        {

        }
        //Maak een method aan die de resolutie weergeeft
         public string GetResolutionInfo()
        {
            //Maak een local variabele aan die de totale pixels berekent.
           int totalpixels = displayWidth * displayHeight;
            return $"Resolution: {totalpixels} pixels";
        }
        //Maak een method die de Storage laat zien in een string
        public override string DisplayStorageCapacity()
        {
            int capacity = mBSize;
            return $"{capacity} mB.";
        }
        //Maak een method die de isEjected boolean toggled.
        public bool Eject()
        {
            if (isEjected == true)
            {

                isEjected = false;
            }
            else if (isEjected == false)
            {
                isEjected = true;
            }
            return isEjected;
        }
        //Voeg public properties toe
        public int MbSize { get { return mBSize; } }
        public int DisplayWidth { get { return displayWidth; } set { displayWidth = value; } }  
        public int DisplayHeight { get { return displayHeight; } set { displayHeight = value; } }
        public int TotalPixels { get { return displayHeight * displayWidth; } set { TotalPixels = value; } }
        public bool IsEjected { get { return Eject(); } }
    }
}

