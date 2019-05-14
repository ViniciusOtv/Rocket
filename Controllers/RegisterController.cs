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
    public class RegisterController : ControllerBase
    {
        private readonly UserContext _context;

        public RegisterController(UserContext context)
        {
            _context = context;
        }

        //POST api/values
        [HttpPost]
        public IActionResult CreateUser([FromBody] User payload)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (payload.IsExisting(payload, _context) != false)
                    {
                        return BadRequest("User already exists");
                    }

                    if (payload.SaveUser(payload, _context) != false)
                    {
                        return new CreatedAtRouteResult("createdNumber", new { id = payload.UserId }, payload);
                    }
                }
            }
            catch (System.Exception)
            {
                throw;
            }

            return BadRequest();
        }
    }
}