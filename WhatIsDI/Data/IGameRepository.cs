using System.Collections.Generic;
using WhatIsDI.Models;



namespace WhatIsDI.Data
{
    public interface IGameRepository
    {
        List<Game> GetGames();
    }
}