using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameMarketMVC.Models.Games;

namespace GameMarketMVC.Models.Interfaces
{
    public interface IGameRepository
    {
        IQueryable<Game> Games { get; }
    }
}
