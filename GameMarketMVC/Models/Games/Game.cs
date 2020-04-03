using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMarketMVC.Models.Games
{
    public class Game
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public string Company { get; set; }
        public string Ganre { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Price { get; set; }
    }
}
