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
using Rocket.Report.Results;

namespace Rocket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserContext _context;
        private IUserService _userService;
        

        /// <summary>
        ///
        /// </summary>
        /// <param name ="userService"></param>
        public UserController(UserContext userContext, IUserService userService)
        {
            _context = userContext; 
            _userService = userService;
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
