using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices
{
   public class TrackList
    {
        //Maak een private field aan gemaakt tracks
       private List<Tracks> tracks;
        public TrackList()
        {
            this.tracks = new List<Tracks>();
        }
        public TrackList(List<Tracks> tracks)
        {
            //voeg de tracks toe aan de bovenstaande private field tracks.
            this.tracks = tracks;
        }
                    //Maak een method die een bepaalde track toevoegd met behulp van de add(); method.
        public void Add(Tracks addTrack)
        {
            tracks.Add(addTrack);
        }
                    //Maak een method die een bepaalde track verwijdert met behulp van de Remove(); method.
        public void Remove(Tracks removeTrack)
        {
            tracks.Remove(removeTrack);
        }
                    //Maak een method die alle tracks cleart met behulp van de Clear(); method.
        public void Clear(Tracks clearTrack)
        {
            tracks.Clear();
        }
                    //Maak een method die alle tracks opvraagt.
        public List<Tracks> GetAllTracks()
        {
            return tracks;
        }
        public List<Tracks> Shuffle()
        {
                        //Maak een tijdelijke nieuwe lijst aan waar de tracks aan toegevoegd kunnen worden.
            List<Tracks> temp = new List<Tracks>();
                        //Voor elke track in de lijst van Tracks voeg de track toe aan de tijdelijke lijst genaamd temp.
            foreach (var track in tracks)
            {
                temp.Add(track);
            }
                        //Maak een lijst aan waar de tracks in random volgorde ingezet worden genaamd shuffledTracks.
            List<Tracks> shuffledTracks = new List<Tracks>();
                        //Maak een nieuw random object aan om straks een random track uit de temp lijst te halen.
            Random rng = new Random();
                        //Wanneer de lijst temp nog gevuld is met tracks voer het volgende uit:
            while (temp.Count > 0)
            {
                            //Zorgt ervoor dat met random.next een random nummer uit de lijst van tracks gehaald word.
                int rndNumber = rng.Next(temp.Count);
                            //Voeg het gekozen random nummer toe aan de shuffledTracks lijst
                shuffledTracks.Add(temp[rndNumber]);
                            //Verwijder daarna direct het nummer wat je heb toegevoegd aan 
                            //shuffledTracks uit temp zodat het niet redundant kan worden.
                temp.RemoveAt(rndNumber);
                
            }
            return shuffledTracks;
        }
                    //Een property voor totale tracks in de tracklist.
        public int Count
        {
            
            get 
            {
                            //Return de tracks in de vorm van een int.
                return tracks.Count; 
            }
        }
                    //Een property voor de totale tijd in de tracklist.
        public Time TotalTime
        {
            get
            {
                            //Maak een local variabele aan voor de seconden
                int seconds = 0;
                            // Voor elk item in tracks word (als er een Time aanwezig is) 
                            //de lengte omgezet naar seconden en toegevoegd aan de local variabele seconds
                foreach (var item in tracks)
                {
                    seconds += item.GetLengthInSeconds();
                }
                            //Return de seconden met de waardes van de totale lengte in seconden.
                return new Time(seconds);
            }
        }
    }
}
