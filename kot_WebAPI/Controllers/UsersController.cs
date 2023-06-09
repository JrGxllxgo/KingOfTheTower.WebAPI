using BusinessLogic.User;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace kot_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        #region Fields

        private readonly IUserBll _usersBll;

        #endregion

        #region Builder

        public UsersController(IUserBll usersbll) 
        {
            _usersBll = usersbll;
        }    

        #endregion


        // GET: api/<UsersController>
        [HttpGet("getAllUsers")]
        public IActionResult Get()
        {
            try
            {
                var usersList = _usersBll.Get();
                return Ok(usersList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // GET api/<UsersController>/5
        [HttpGet("getUserByEmail/{mail}")]
        public IActionResult Get(string mail)
        {
            try
            {
                var user = _usersBll.Get(mail);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }            
        }

        // POST api/<UsersController>
        [HttpPost("register")]
        public IActionResult Register([FromBody] User value)
        {
            try
            {
                if (null == value)
                    return BadRequest();

                var result = _usersBll.Post(value);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{mail}")]
        public IActionResult Delete(string mail)
        {
            try
            {
                _usersBll.Delete(mail);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
