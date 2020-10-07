using System;

namespace AudioDevices
{
    public class Tracks
    {
        // Initialize private fields
        private int id;
        private string name;
        private string artist;
        private string albumSource;
        private Category style;
        private Time length;

        public int Id { get { return id; } set { } }
        public string Name { get { return name; } set { } }
        public string Artist { get { return artist; } set { } }
        public string DisplayName
        {
            get
            {
                if (String.IsNullOrEmpty(artist) || String.IsNullOrEmpty(name))
                {
                    return "Unknown";
                }
                else
                {
                    return artist + name;
                }
            }
        }
        public Time Length { get { return length; } set { } }
        public string DisplayLength { get { return length.ToString(); } }
        public Category Style { get { return style; } set { } }
        public string AlbumSource { get { return albumSource; } set { } }
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
        public Tracks() { }
        public Tracks(int id) {
            this.id = id;
        }
        public Tracks(int id, string name) {
            this.id = id;
            this.name = name;
        }
        public Tracks(int id, string artist, string name) {
            this.id = id;
            this.name = name;
            this.artist = artist;
        }
    }
    public enum Category
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
