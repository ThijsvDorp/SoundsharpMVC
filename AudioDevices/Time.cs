using System;
using System.Collections.Generic;
using System.Text;

namespace AudioDevices
{
    public class Time
    {
                    //Maak 3 lokale variabelen aan
        int _hours;
        int _minutes;
        int _seconds;
                    //Maak 3 constructors aan die de tijd berekenen.
        public Time(int seconds)
        {
                    //Hier worden seconden omgerekent naar minuten en uren.
            _hours = seconds / 3600;
            _minutes = (seconds % 3600) / 60;
            _seconds = (seconds % 3600) % 60;
        }
                    //In deze constructor worden minuten en seconden omgerekend.
        public Time(int minutes, int seconds) : this(minutes * 60 + seconds)
        {

        }
                    //In deze constructor worden uren, minuten en seconden omgerekend.
        public Time (int hours, int minutes, int seconds) : this(hours * 3600 + minutes * 60 + seconds)
        {
    
        }
        public override string ToString()
        {
                    //Als de waardes van uren, minuten en seconden minder dan 10
                    //is zorg dan dat er een extra 0 voor het cijfer komt te staan zodat het netjes double digits is.
            string result = "";
            result += _hours < 10 ? "0" + _hours : _hours.ToString();
            result += ":";
            result += _minutes < 10 ? "0" + _minutes : _minutes.ToString();
            result += ":";
            result += _seconds < 10 ? "0" + _seconds : _seconds.ToString();

            return result;
        }
    }
}
