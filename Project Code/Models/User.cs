using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _4ALLApp.Models
{
    public class User
    {

        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please enter First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter a City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please choose a State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a Zip Code")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a Phone Numer")]
        public string PhoneNumber { get; set; }
    }
}