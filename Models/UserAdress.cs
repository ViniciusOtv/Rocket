using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;


namespace Rocket.Models
{ 

    public class UserAdress
    {
        public int UserAdressId { get; set; }

        public string Street { get; set; }     

        public int HouseNumber { get; set; }

        public string District {get ; set;} 

        public string State { get; set; }   

        public string Country {get; set; }

        public int UserId {get; set; }

    }

}