using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Rocket.Repository;
using System.ComponentModel.DataAnnotations;
using Rocket.Attributes;
using System.Resources;

namespace Rocket.Contracts.User
{
    public class GetUserByIdRequest
    {
        ///<summary>
        ///Identificador do usuário
        ///</summary>

        // [Required(ErrorMessageResourceType = typeof(), ErrorMessageResourceName = "Required field")]
        public int UserId { get; set; }

    }
}