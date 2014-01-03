using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegGadget.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
    }
}