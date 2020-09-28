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
