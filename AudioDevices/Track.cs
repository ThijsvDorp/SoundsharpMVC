using System;

namespace AudioDevices
{
    public class Track
    {
        private int id;
        private string name;
        private string artist;
        private string albumSource;
        private category style;
        private Time length;
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
