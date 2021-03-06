﻿using AudioDevices;
using SoundsharpMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SoundsharpMVC.Controllers
{
    public class TrackController : Controller
    {

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //Probeer alle info op te slaan en toe te voegen aan de tracklist.
                int hours = int.Parse(collection["Hours"]);
                int minutes = int.Parse(collection["Minutes"]);
                int seconds = int.Parse(collection["Seconds"]);
                Tracks track = new Tracks();
                track.Name = collection["Name"];
                track.Artist = collection["Artist"];
                track.AlbumSource = collection["AlbumSource"];
                track.Length = new AudioDevices.Time(hours, minutes, seconds);
                track.Style = (Category)Enum.Parse(typeof(Category), collection["Style"]);
                trackList1.Add(track);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private static TrackList trackList1;
        public TrackController()
        {
            if (trackList1 == null)
            {
                trackList1 = DataProvider.GenerateDefaultTracks();
            }
        }

        // GET: Track
        public ActionResult Index()
        {
            return View(trackList1);
        }

        // GET: Track/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: Track/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Track/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Track/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Track/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
