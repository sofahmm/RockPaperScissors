using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockPaperScissors_Core;

namespace RSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private static readonly string[] Player_opponent = new[]
        {
            "Камень","Ножницы","Бумага"
        };
        private readonly ILogger<PlayerController> _logger;
        public PlayerController (ILogger<PlayerController> logger)
        {
            _logger = logger;
        }

        //public void Met(int n, int m)
        //{
        //    return Player.XodPlayers(n, m);
        //}
        [HttpGet]
        public IEnumerable<Figure> Get()
        {
            var opponent = new Random();
            var name = new Random();
            //Player player = Player.XodPlayers(name, opponent);
            return Enumerable.Range(1, 3).Select(index => new Figure
            {
                Name = name.Next(0, 3),
                Opponent = opponent.Next(0,3)
            })
                .ToArray();
        }
    }
}
