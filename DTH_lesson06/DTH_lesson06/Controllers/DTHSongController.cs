using DTH_lesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTH_lesson06.Controllers
{
    public class DTHSongController : Controller
    {
        // GET: DTHSong
        private static List<DTHSong> dTHSongs = new List<DTHSong>()
        {
            new DTHSong{ID = 100, dthTitle="Đỗ Trọng Huy",dthAuthor="K22CNT1", dthArtist="Huy Huy", dthYearRelease=2024},
            new DTHSong{ID = 101, dthTitle="Love You ",dthAuthor="K22CNT1", dthArtist="Huy Huy", dthYearRelease=1999},
        };
        public ActionResult DTHSong()
        {
            return View(dTHSongs);
        }
        public ActionResult DTHCreate()
        {
            var dthSong = new DTHSong();
            return View(dthSong);
        }
        [HttpPost]
        public ActionResult DthCreate(DTHSong dTHSong)
        {
            if (!ModelState.IsValid)
            {
                return View(dTHSong);
            }
            dTHSongs.Add(dTHSong);
            return RedirectToAction("DTHSong");
        }
    }
}