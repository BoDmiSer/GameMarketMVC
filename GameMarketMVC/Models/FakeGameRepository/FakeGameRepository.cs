using GameMarketMVC.Models.Games;
using GameMarketMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMarketMVC.Models.FakeGameRepository
{
    public class FakeGameRepository : IGameRepository
    {
        public IQueryable<Game> Games => new List<Game>
        {
            new Game
            {
                Name="PayDay2",
                Company="Software",
                Ganre="Action",
                Price=499,
                DateTime=DateTime.Now
            },
            new Game
            {
                Name="Assassins Creed",
                Company="Ubisoft",
                Ganre="Action",
                Price=499,
                DateTime=DateTime.Now
            },
        }.AsQueryable<Game>();
    }
}
