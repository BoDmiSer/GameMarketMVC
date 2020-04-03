using GameMarketMVC.Models.Games;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMarketMVC.Models.GameRepository
{
    public class GameContext: DbContext
    {
        public DbSet<Game> Games { get; set; }
        public GameContext(DbContextOptions<GameContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
