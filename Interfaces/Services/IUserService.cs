using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Rocket.Contracts.User;
using Rocket.Report.Results;


namespace Rocket.Interface.Services
{
    public interface IUserService
    {
        Task<MethodResult> GetUserById(GetUserByIdRequest request);
    }
}