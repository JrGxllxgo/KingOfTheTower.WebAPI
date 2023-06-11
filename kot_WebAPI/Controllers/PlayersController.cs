using BusinessLogic.Player;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace kot_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        #region Fields

        private readonly IPlayerBll _playersBll;

        #endregion

        #region Builder

        public PlayersController(IPlayerBll playersBll)
        {
            _playersBll = playersBll;
        }

        #endregion

        // GET: api/<PlayersController>
        [HttpGet("getAllPlayers")]
        public IActionResult Get()
        {
            try
            {
                var playerList = _playersBll.Get();

                return Ok(playerList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<PlayersController>/5
        [HttpGet("getPlayerByNif/{nif}")]
        public IActionResult Get(string nif)
        {
            try
            {
                var team = _playersBll.Get(nif);

                return Ok(team);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // POST api/<PlayersController>
        [HttpPost("register")]
        public IActionResult Post([FromBody] IEnumerable<Player> value)
        {
            try
            {
                if (null == value)
                    return BadRequest();

                var result = _playersBll.Post(value);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<PlayersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlayersController>/5
        [HttpDelete("{id}")]
        public void Delete(string name)
        {
        }
    }
}
