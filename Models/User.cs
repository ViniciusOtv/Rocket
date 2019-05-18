using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Rocket.Repository;
using System.ComponentModel.DataAnnotations;


namespace Rocket.Models
{
    public class User
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


        public bool IsExisting(User payload, UserContext context)
        {
            var validateUser = context.Users.FirstOrDefault(x => x.Document == payload.Document);

            if (validateUser != null)
            {
                return true;
            }

            return false;
        }

        public bool SaveUser(User payload, UserContext context)
        {
            try
            {
                payload.Date_Creation = DateTime.Now;
                context.Users.Add(payload);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }

            return true;
        }
    }
}