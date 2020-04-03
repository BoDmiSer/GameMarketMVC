using GameMarketMVC.Models.Games;
using GameMarketMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMarketMVC.Models.GameRepository
{
    public class EFGameRepository: IGameRepository
    {
        private GameContext context;
        public EFGameRepository(GameContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Game> Games => context.Games;
    }
}
