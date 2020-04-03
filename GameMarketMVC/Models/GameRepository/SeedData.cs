using GameMarketMVC.Models.Games;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMarketMVC.Models.GameRepository
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            GameContext gameContext = app.ApplicationServices.GetRequiredService<GameContext>();
            gameContext.Database.Migrate();
            if (!gameContext.Games.Any())
            {
                gameContext.Games.AddRange(

            new Game
            {
                Name = "PayDay2",
                Company = "Software",
                Ganre = "Action",
                Price = 499,
                DateTime = DateTime.Now
            },
            new Game
            {
                Name = "Assassins Creed",
                Company = "Ubisoft",
                Ganre = "Action",
                Price = 499,
                DateTime = DateTime.Now
            },
            new Game
            {
                Name = "Assassins Creed 2",
                Company = "Ubisoft",
                Ganre = "Action",
                Price = 499,
                DateTime = DateTime.Now // Ошибка при миграции, после её создания пишет что объект создан
            });
            }
            gameContext.SaveChanges();
        }
    }
}
