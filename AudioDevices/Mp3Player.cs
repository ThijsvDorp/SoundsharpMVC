﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AudioDevices.Interfaces.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace AudioDevices.Devices
{
    class Mp3Player : ITrackList
    {

        //Initialiseer private fields
        private TrackList trackList;
        private int mBSize = 0;
        private int displayWidth;
        private int displayHeight;
        private string picture;

        //public TrackList TrackList => throw new NotImplementedException();

        //Constructor
        public Mp3Player() {  }
        public string GetResolutionInfo()
        {
            //Maak een local variabele aan die de totale pixels berekent.
            int totalpixels = displayWidth * displayHeight;
            return $"Resolution: {totalpixels} pixels";
        }
        public bool HasTracks()
        {
            if (trackList == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
       public void AddTrackList(TrackList trackList) 
       {
            
       }
       public void RemoveTrackList() { }
       public string DisplayStorageCapacity()
       {
            int capacity = mBSize;
            if (capacity == 0 || capacity < 0)
            {
                return "Storage capacity unknown";
            }
            else
            {
                return $"{capacity} mB.";
            }
       }
        public int MbSize { get { return mBSize; } set { mBSize = value; } }
        public int DisplayWidth { get { return displayWidth; } set { displayWidth = value; } }
        public int DisplayHeight { get { return displayWidth; } set { displayWidth = value; } }
        public int TotalPixels { get { return displayHeight * displayWidth; } set { TotalPixels = value; } }
        public TrackList TrackList { get { return TrackList; } }
        public string Picture { get { return picture; } set { picture = ; } }
    }
}
