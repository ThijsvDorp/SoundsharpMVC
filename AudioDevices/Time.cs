using System;
using System.Collections.Generic;
using System.Text;

namespace AudioDevices
{
    public class Time
    {
        int _hours;
        int _minutes;
        int _seconds;
        public Time(int seconds)
        {
            _hours = seconds / 3600;
            _minutes = (seconds % 3600) / 60;
            _seconds = (seconds % 3600) % 60;
        }
        public Time(int minutes, int seconds) : this(minutes * 60 + seconds)
        {

        }
        public Time (int hours, int minutes, int seconds) : this(hours * 3600 + minutes * 60 + seconds)
        {
    
        }
        public override string ToString()
        {
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
