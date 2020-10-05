using System;

namespace AudioDevices
{
    public class Track
    {
        // Initialize private fields
        private int id { get; set; }
        private string name;
        private string artist;
        private string albumSource;
        private category style;
        private Time length;

        public Time GetLength()
        {
            return length;
        }
        public int GetLengthInSeconds()
        {
            //uur:minuut:seconden
            string[] time = length.ToString().Split(':');
            int seconds = (Convert.ToInt32(time[0]) * 3600) + (Convert.ToInt32(time[1]) * 60) + (Convert.ToInt32(time[2]));
            return GetLengthInSeconds();
        }
        public Track() { }
        public Track(int id) {
            this.id = id;
        }
        public Track(int id, string name) {
            this.id = id;
            this.name = name;
        }
        public Track(int id, string artist, string name) {
            this.id = id;
            this.name = name;
            this.artist = artist;
        }
    }
    public enum category
    {
        Ambient,
        Blues,
        Country,
        Disco,
        Electro,
        Hardcore,
        HardRock,
        HeavyMetal,
        Hiphop,
        Jazz,
        Jumpstyle,
        Klassiek,
        Latin,
        Other,
        Pop,
        Punk,
        Reggae,
        Rock,
        Soul,
        Trance,
        Techno
   

    }
}
