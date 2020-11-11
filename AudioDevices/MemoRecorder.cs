using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public class MemoRecorder : AudioDevice
    {
        private MemoCartRidgeType maxCartRidgeType;
        //Maak een enum met alle verschillende cartridge soorten.
        public enum MemoCartRidgeType
        {
            c60,
            c90,
            c120,
            anders
        }
        //Implementeer de abstract method van Audiodevice.cs
        public override string DisplayStorageCapacity()
        {
             string str = "";
            //Checkt welke capacity de cartridge heeft dmv een switch
            switch (maxCartRidgeType)
            {
                case MemoCartRidgeType.c60: 
                    str = "Max capacity 60 min.";
                    break;
                case MemoCartRidgeType.c90: 
                    str = "Max capacity 90 min.";
                    break;
                case MemoCartRidgeType.c120:
                    str = "Max capacity 120 min.";
                    break;
                case MemoCartRidgeType.anders:
                    str = "Max capacity unknown";
                    break;
            }
            return str;
        }
        //Constructor voor Memorecorder
        public MemoRecorder()
        {
     
        }
        
        public MemoCartRidgeType MaxCartridgeType { get { return maxCartRidgeType;} set { maxCartRidgeType = value; } }
    }
}
