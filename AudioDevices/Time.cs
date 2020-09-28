using System;
using System.Collections.Generic;
using System.Text;

namespace AudioDevices
{
    class Time
    {
        int _hours;
        int _minutes;
        int _seconds;
        public Time(int seconds)
        {
         
        }
        public Time(int minutes, int seconds)
        {
            _hours = minutes / 60;
            _minutes = minutes % 60;
            _seconds = seconds;
        }
        public Time (int hours, int minutes, int seconds)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
        }
    }
}
