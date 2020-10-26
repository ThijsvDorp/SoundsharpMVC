using AudioDevices;
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

    }
}