using BusinessLogic.Team;
using BusinessLogic.User;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace kot_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        #region Fileds

        private readonly ITeamBll _teamsBll;

        #endregion

        #region Builder

        public TeamsController(ITeamBll teamsbll)
        {
            _teamsBll = teamsbll;
        }

        #endregion

        // GET: api/<UsersController>
        [HttpGet("getAllTeams")]
        public IActionResult Get()
        {
            try
            {
                var teamList = _teamsBll.Get();

                return Ok(teamList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/TeamsController>/5
        [HttpGet("getTeamByName/{name}")]
        public IActionResult Get(string name)
        {
            try
            {
                var team = _teamsBll.Get(name);

                return Ok(team);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("getTeamClassByGroup/{groupName}")]
        public IActionResult GetClassif(string groupName)
        {
            try
            {
                var teams = _teamsBll.GetClassif(groupName);

                return Ok(teams);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // GET api/TeamsController>/5
        [HttpGet("getTeamByGroup/{groupName}")]
        public IActionResult GetByGroup(string groupName)
        {
            try
            {
                var teams = _teamsBll.GetByGroup(groupName);

                return Ok(teams);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // POST api/<TeamsController>
        [HttpPost("register")]
        public IActionResult Post([FromBody] Team value)
        {
            try
            {
                var result = _teamsBll.Post(value);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<TeamsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeamsController>/5
        [HttpDelete("{id}")]
        public void Delete(string name)
        {
        }
    }
}
