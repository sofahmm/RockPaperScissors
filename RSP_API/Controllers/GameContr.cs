using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockPaperScissors_Core;
using RSP_API.Models;
using RSP_API.Service;

namespace RSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameContr : ControllerBase
    {


        // GET all action
        [HttpGet]
        public ActionResult<List<Figure>> GetAll() => GameService.GetAll();

        // GET by Id action

        [HttpGet("{id}")]
        public ActionResult<Figure> Get(int id)
        {
            var fig = GameService.Get(id);
            if (fig == null)
                return NotFound();
            return fig;
        }

        // POST action
        [HttpPost]
        public IActionResult Create(Figure figure)
        {
            GameService.Add(figure);
            return CreatedAtAction(nameof(Create), new { id = figure.ID }, figure);
        }
        // PUT action
        [HttpPut("{id}")]
        public IActionResult Update(int id, Figure figure)
        {
            if (id != figure.ID)
                return BadRequest();
            var existingGame = GameService.Get(id);
            if (existingGame is null)
                return NotFound();
            GameService.Update(figure);

            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            var fig = GameService.Get(id);
            if (fig is null)
                return NotFound();
            GameService.Delete(id);
            return NoContent();
        }
    }
}
