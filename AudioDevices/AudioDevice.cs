using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    //Maak een abstracte class aan, een abstracte class kan niet geinstantieerd worden.
    abstract class AudioDevice
    {
        //Maak een aantal private fields aan.
        private int serialId;
        private string model;
        private string make;
        private decimal priceExBtw;
        private DateTime creationDate;
        protected readonly static double btwPercentage = 19.0;
        //Maak een method aan die de Serial ID teruggeeft.
        public string DisplayIdentity()
        {
            string text = "Serial: " + serialId;
            return text;
        }
        //Overload deze method met 2 parameters die kijken of
        public string DisplayIdentity(bool makeInfo, bool modelInfo)
        {
            string text = "Serial: " + serialId;
            //Als makeInfo true is, voeg een string toe die Make laat zien.
            if (makeInfo == true)
            {
                text += " Make:" + make;
            }
            //Als modelInfo true is, voeg een string toe die Model laat zien.
            if (modelInfo == true)
            {
                text += " Model:" + model;
            }
            return text;
        }
        public string GetDeviceLifeTime()
        {
            return "";
        }
        //Maak een aantal public properties die getten of setten.
        public int SerialId { get { return serialId; } }
        public string Model { get { return model; } set { } }
        public string Make { get { return make; } set { } }
        public decimal PriceExBtw { get { return priceExBtw; } set { } }
        public decimal ConsumerPrice { get { return 0; } }
        public DateTime CreationDate { get { return creationDate; } set { } }
    }
}
