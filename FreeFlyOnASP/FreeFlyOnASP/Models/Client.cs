using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FreeFlyOnASP.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(25)]
        public string  Name { get; set; }

        [MaxLength(25)]
        public string Surname { get; set; }

        public string Adress { get; set; }

        [MinLength(5)]
        public string Login { get; set; }

        [MinLength(5)]
        public string Password { get; set; }  

        public string Email { get; set; }
            
        public List<Order> Orders { get; set; }

        public DateTime BirthDate { get; set; }


    }
}