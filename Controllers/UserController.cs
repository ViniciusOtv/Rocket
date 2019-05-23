using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rocket.Repository;
using Rocket.Models;
using Rocket.Interface.Services;
using Rocket.Contracts.User;
using Rocket.Services;

namespace Rocket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserContext _context;
        private readonly IUserService _userService;
        
        public UserController(UserContext userContext)
        {
            _context = userContext; 
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Users.ToList());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] GetUserByIdRequest request)
        {
            var response = await _userService.GetUserById(request);
            return Ok();
        }
    }
}
