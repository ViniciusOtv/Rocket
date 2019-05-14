using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Rocket.Repository;
using System.ComponentModel.DataAnnotations;


namespace Rocket.Contracts.User
{
    public class GetUserResponse
    {
        public int UserId { get; set; }

        public string Document { get; set; }

        public string Name { get; set; }

        public int CodeArea { get; set; }

        public string CellPhone { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Email { get ; set; }

        public int Account_Status { get; set; }

        public DateTime  Date_Creation {get; set;}
    }
}