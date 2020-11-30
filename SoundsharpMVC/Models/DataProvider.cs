using AudioDevices;
using AudioDevices.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundsharpMVC.Models
{
    public static class DataProvider
    {
        public static TrackList GenerateDefaultTracks()
        {
            //Maak een lijst genaamd trackList aan en instantieer een nieuwe list.
            TrackList trackList1 = new TrackList();
            //Track 1
            Tracks t1 = new Tracks();
            t1.Name = "Yellow";
            t1.Artist = "Coldplay";
            t1.AlbumSource = "Parachutes";
            t1.Length = new AudioDevices.Time(0, 4, 29);
            t1.Style = Category.Pop;

            //Track 2
            Tracks t2 = new Tracks();
            t2.Name = "Shiver";
            t2.Artist = "Coldplay";
            t2.AlbumSource = "Parachutes";
            t2.Length = new AudioDevices.Time(0, 4, 59);
            t2.Style = Category.Pop;

            //Track 3
            Tracks t3 = new Tracks(0, "Maneater");
            
            t3.Artist = "Nelly Futado";
            t3.AlbumSource = "Loose";
            t3.Length = new AudioDevices.Time(281);

            //Track 4
            Tracks t4 = new Tracks(4, "Guitar", "Prince");
            t4.Style = Category.Pop;
            t4.Length = new AudioDevices.Time(2, 72);

            //Voeg de tracks toe aan de list
            trackList1.Add(t1);
            trackList1.Add(t2);
            trackList1.Add(t3);
            trackList1.Add(t4);
            return trackList1;
            
        }
        //Maak een lijst met memorecorders
        public static List<MemoRecorder> GetDefaultMemorecorders()
        {
            List<MemoRecorder> recorders = new List<MemoRecorder>();
            MemoRecorder mr1 = new MemoRecorder();
            mr1.Make = "Sony";
            mr1.Model = "ICD-BX700";
            mr1.PriceExBtw = 49.99m;
            mr1.CreationDate = new DateTime(2010, 10, 1);
            MemoRecorder mr2 = new MemoRecorder();
            mr2.Make = "Philips";
            mr2.Model = "Voice Tracer LF";
            mr2.PriceExBtw = 139.00m;
            mr2.CreationDate = new DateTime(2010, 1, 10);
            MemoRecorder mr3 = new MemoRecorder();
            mr3.Make = "Olympus";
            mr3.Model = "VN 500";
            mr3.PriceExBtw = 30.00m;
            mr3.CreationDate = new DateTime(2010, 1, 5);
            recorders.Add(mr1);
            recorders.Add(mr2);
            recorders.Add(mr3);
            return recorders;
        }
        public static List<CdDiscMan> GetDefaultCdDiscMan()
        {
            List<CdDiscMan> DiscMans = new List<CdDiscMan>();
            CdDiscMan dm1 = new CdDiscMan();
            dm1.DisplayWidth = 5;
            dm1.DisplayHeight = 5;
            dm1.Make = "Sony";
            dm1.Model = "XP10";

            CdDiscMan dm2 = new CdDiscMan();
            dm2.DisplayWidth = 6;
            dm2.DisplayHeight = 6;
            dm2.Make = "Sony";
            dm2.Model = "XP20";

            CdDiscMan dm3 = new CdDiscMan();
            dm3.DisplayWidth = 7;
            dm3.DisplayHeight = 7;
            dm3.Make = "Olympus";
            dm3.Model = "VN 600";

            CdDiscMan dm4 = new CdDiscMan();
            dm4.DisplayWidth = 8;
            dm4.DisplayHeight = 8;
            dm4.Make = "Test";
            dm4.Model = "Test1";

            DiscMans.Add(dm1);
            DiscMans.Add(dm2);
            DiscMans.Add(dm3);
            DiscMans.Add(dm4);
            return DiscMans;
        }
        public static List<Mp3Player> GetDefaultMp3Players()
        {
            List<Mp3Player> mp3Players = new List<Mp3Player>();
            Mp3Player mp1 = new Mp3Player();
            mp1.MbSize = 100;
            mp1.DisplayHeight = 10;
            mp1.DisplayWidth = 10;
            Mp3Player mp2 = new Mp3Player();
            mp2.MbSize = 200;
            mp2.DisplayHeight = 15;
            mp2.DisplayWidth = 15;
            Mp3Player mp3 = new Mp3Player();
            mp3.MbSize = 300;
            mp3.DisplayHeight = 15;
            mp3.DisplayWidth = 15;
            Mp3Player mp4 = new Mp3Player();
            mp4.MbSize = 400;
            mp4.DisplayHeight = 20;
            mp4.DisplayWidth = 20;
            mp3Players.Add(mp1);
            mp3Players.Add(mp2);
            mp3Players.Add(mp3);
            mp3Players.Add(mp4);
            return mp3Players;
        }
    }
}