using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    //Maak een abstracte class aan, een abstracte class kan niet geinstantieerd worden.
   public abstract class AudioDevice
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
        //Method die de leeftijd van de Device in dagen uitrekent
        public string GetDeviceLifeTime()
        {
            //Als de waarde niet gelijk is aan de default waarde van DateTime,
            //reken dan het verschil in dagen uit en geef het terug als een string.
            if (creationDate != default(DateTime))
            {
                //Pak de datum van vandaag, en subtract die van creationDate (als het een waarde heeft)
                TimeSpan diff = DateTime.Now.Subtract(this.creationDate);
                return $"Lifetime {diff} days";
            }
            else
            {
                return "Lifetime unknown";
            }
        }
        public abstract string DisplayStorageCapacity();

        protected static int lastID = 1;
        //Maak een aantal public properties die getten of setten.
        public int SerialId { get { return serialId; } }
        public string Model { get { return model; } set { model = value; } }
        public string Make { get { return make; } set { make = value; } }
        public decimal PriceExBtw { get { return priceExBtw; } set { priceExBtw = value; } }
        public decimal ConsumerPrice { get { return 0; } }
        public DateTime CreationDate { get { return creationDate; } set { creationDate = value; } }
    }
}
