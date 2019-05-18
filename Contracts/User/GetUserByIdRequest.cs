using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Rocket.Repository;
using System.ComponentModel.DataAnnotations;
using Rocket.Attributes;

namespace Rocket.Contracts.User
{
    public class GetUserByIdRequest
    {
        ///<summary>
        ///Identificador do usuário
        ///</summary>

        [Range(1, int.MaxValue, ErrorMessageResourceName = "ValorInvalido")]
        [Required(ErrorMessageResourceName = "Required field")]
        public int UserId { get; set; }

    }
}