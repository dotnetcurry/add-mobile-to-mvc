using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddingMobileSupportToMVC.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}