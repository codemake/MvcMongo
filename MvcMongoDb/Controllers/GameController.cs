using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System;
using System.Web.Mvc;
using MvcMongoDb.Data.Entities;
using MvcMongoDb.Data.Services;

namespace MvcMongoDb.Controllers
{
    public class GameController : Controller
    {
        //
        // GET: /Game/Create

        public ActionResult Create()
        {
            return View(
                new Game()
                {
                    ReleaseDate = DateTime.Today,
                    Played = false
                });
        }

        //
        // POST: /Game/Create

        [HttpPost]
        public ActionResult Create(Game game)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var gameService = new GameService();
                    gameService.Create(game);
                    return RedirectToAction("Index");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Game/

        public ActionResult Index()
        {
            var gameService = new GameService();
            var gamesDetails = gameService.GetGamesDetails(100, 0);

            return View(gamesDetails);
        }

    }
}
