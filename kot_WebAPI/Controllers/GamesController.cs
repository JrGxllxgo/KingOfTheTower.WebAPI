using BusinessLogic.Game;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace kot_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        #region Fields

        private readonly IGameBll _gamesBll;

        #endregion

        #region Builder

        public GamesController(IGameBll gamesBll)
        {
            _gamesBll = gamesBll;
        }

        #endregion


        // GET: api/<UsersController>
        [HttpGet("getAllGames")]
        public IActionResult Get()
        {
            try
            {
                var gamesList = _gamesBll.Get();

                return Ok(gamesList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // GET api/<UsersController>/5
        [HttpGet("getGameById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var game = _gamesBll.Get(id);

                return Ok(game);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // POST api/<UsersController>
        [HttpPost("register")]
        public IActionResult Register([FromBody] Game value)
        {
            try
            {
                _gamesBll.Post(value);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _gamesBll.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
