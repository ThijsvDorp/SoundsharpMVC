using AudioDevices.Devices;
using SoundsharpMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoundsharpMVC.Controllers
{
    public class Mp3PlayerController : Controller
    {
        private static List<Mp3Player> mp3Player;
        
        public Mp3PlayerController()
        {
            if (mp3Player == null)
            {
                mp3Player = DataProvider.GetDefaultMp3Players();
            }
        }
        // GET: Mp3Player
        public ActionResult Index()
        {
            List<VMMp3Player> mp3Players = new List<VMMp3Player>();
            foreach (var item in mp3Player)
            {
                VMMp3Player Mp3p = new VMMp3Player();
                Mp3p.DisplayHeight = item.DisplayHeight;
                Mp3p.DisplayWidth = item.DisplayWidth;
                Mp3p.MbSize = item.MbSize;
                Mp3p.Picture = item.Picture;
                Mp3p.TotalPixels = item.TotalPixels;
                mp3Players.Add(Mp3p);
            }
            return View(mp3Players);
        }

        // GET: Mp3Player/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mp3Player/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mp3Player/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Mp3Player player = new Mp3Player();
                player.MbSize = int.Parse(collection["MbSize"]);
                player.DisplayHeight = int.Parse(collection["DisplayHeight"]);
                player.DisplayWidth = int.Parse(collection["DisplayWidth"]);
                player.TotalPixels = int.Parse(collection["TotalPixels"]);
                mp3Player.Add(player);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mp3Player/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mp3Player/Edit/5
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

        // GET: Mp3Player/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mp3Player/Delete/5
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
