using Microsoft.AspNetCore.Mvc;
using WhatIsDI.Data;



namespace WhatIsDI.Controllers
{
    public class GameController : Controller
        
    {
        private readonly IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }
        public IActionResult Index()
        {
           
            //GameRepository gameRepository = new GameRepository();
            //var games = gameRepository.GetGames();
            var games = _gameRepository.GetGames();
            return View(games);
        }
    }
}