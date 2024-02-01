﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace testNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GamesController(IGameService gameService)
        {
            this._gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Game>>> GetAllGames()
        {
            return await _gameService.GetAllGames();
        }

        [HttpPost]
        public async Task<ActionResult<Game>> AddGame(Game game)
        {
            return Ok(await _gameService.AddGame(game));
        }

    }
}
