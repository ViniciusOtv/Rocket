using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Rocket.Repository;
using System.ComponentModel.DataAnnotations;
using Rocket.Attributes;



namespace Rocket.Contracts.User
{
    public class GetUserRequest
    {
        ///<summary>
        ///Identificador do usuário
        ///</summary>

        [Range(1, int.MaxValue, ErrorMessageResourceName = "ValorInvalido")]
        [Required(ErrorMessageResourceName = "Required field")]
        public int UserId { get; set; }

        [Required(ErrorMessageResourceName = "CampoObrigatorio")]
        [DocumentValidation(ErrorMessageResourceName = "Valor inválido")]
        [Display(Name = "Cpf")]
        [StringLength(14, ErrorMessageResourceName = "TamanhoInvalido", MinimumLength = 11)]
        public string Document { get; set; }

        public string Name { get; set; }

        public int CodeArea { get; set; }

        public string CellPhone { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int Account_Status { get; set; }

        public DateTime Date_Creation { get; set; }

    }
}