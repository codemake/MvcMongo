using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using MvcMongoDb.Data.Entities;

namespace MvcMongoDb.Models
{
    public class PlayerGames
    {
        public Player Player { get; set; }

        public List<Game> AvailableGames { get; set; }
    }
}