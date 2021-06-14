using System.Collections.Generic;
using WhatIsDI.Models;



namespace WhatIsDI.Data
{
    public class GameRepository: IGameRepository
    {
        public List<Game> GetGames()
        {
            return new List<Game>
            {
                new Game{Id=1,Name="Civilization",ListPrice=10},
                new Game{Id=2,Name="Portal",ListPrice=15},
                new Game{Id=3,Name="Europa Universalis 4",ListPrice=12 },
                new Game{Id=4,Name="Tomb Raider",ListPrice=9}
            };
        }
    }
}

