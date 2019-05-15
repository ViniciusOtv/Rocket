using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Rocket.Contracts.User;
using Rocket.Report.Results;

namespace Rocket.Interface.Services
{
    public interface IUsuarioService
    {
        Task<MethodResult> GetUserById(GetUserRequest request);
    }
}