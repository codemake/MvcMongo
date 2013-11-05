using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MvcMongoDb.Data.Entities;
using MongoDB.Driver.Builders;

namespace MvcMongoDb.Data.Services
{
    public class GameService : EntityService<Game>
    {
        public IEnumerable<Game> GetGamesDetails(int limit, int skip)
        {
            var gamesCursor = this.MongoConnectionHandler.MongoCollection.FindAllAs<Game>()
                .SetSortOrder(SortBy<Game>.Descending(g => g.ReleaseDate))
                .SetLimit(limit)
                .SetSkip(skip)
                .SetFields(Fields<Game>.Include(g => g.Id, g => g.Name, g => g.ReleaseDate));
            return gamesCursor;
        }


        public override void Update(Game entity)
        {
            //// Not necessary for the example
        }
    }
}
