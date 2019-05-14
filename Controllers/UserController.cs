using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rocket.Repository;
using Rocket.Models;


namespace Rocket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_context.Users.ToList());
        }

        // GET api/values/5

        [HttpGet("{id}", Name = "createdNumber")]
        public ActionResult<string> GetUserById(int id)
        {
            try
            {
                var payload = _context.Users.FirstOrDefault(x => x.UserId == id);
                if (payload == null)
                {
                    return BadRequest("NotFound");
                }
                else
                {
                    return Ok(payload);
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult UPdateDataUser(int id, User payload)
        {
            var putUser = _context.Users.Find(id);

            if (putUser == null)
            {
                return NotFound();
            }

            putUser.Name = payload.Name;

            putUser.CodeArea = payload.CodeArea;

            putUser.CellPhone = payload.CellPhone;

            putUser.PhoneNumber = payload.PhoneNumber;

            _context.Users.Update(putUser);
            _context.SaveChanges();
            return NoContent();

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var delUser = _context.Users.Find(id);

            if (delUser == null)
            {
                return NotFound();
            }

            _context.Users.Remove(delUser);
            _context.SaveChanges();
            return Ok();
        }
    }
}
