using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rocket.Contracts.User;
using Rocket.Report.Results;
using Rocket.Report.Services;
using Rocket.Interface.Services;
using Rocket.Contracts;
using Rocket.Repository;
using Microsoft.Extensions.Configuration;
using PortalParceiros.Application.Interfaces.Repositories;

namespace Rocket.Services
{
    public class UserService : ServiceBase, IUserService
    {
        private readonly IUserRepository _usuarioRepository;
        public async Task<MethodResult> GetUserById(GetUserByIdRequest request)
        {
            if (!Validate(request))
            {
                return BadRequest(ErrorBuilder.ToList());
            }

            var user = await _usuarioRepository.GetUserById(request.UserId);

        }
    }
}