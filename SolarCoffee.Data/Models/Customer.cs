using System;

namespace SolarCoffee.Data.Models
{
    public class Customer
    {
        public int Id {get; set;}
        public DateTime CteatedOn {get; set;}
        public DateTime UpdatedOn {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}

    }
}