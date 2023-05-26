﻿using GolfScore.Models.Request;
using GolfScore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GolfScore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : BaseController
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        public IActionResult GetPlayer(string externalIdentifier, string authCode)
        {
            return HandleRequest(() => _playerService.GetPlayer(externalIdentifier, authCode));
        }

        [HttpPost]
        public IActionResult CreatePlayer(CreatePlayerRequest request)
        {
            return HandleRequest(() => _playerService.CreatePlayer(request));
        }
    }
}
