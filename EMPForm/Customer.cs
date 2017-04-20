using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3680
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsAlumnum { get; set; }
        public int CurrentAge
        {
            get
            {
                DateTime current = DateTime.Now;
                int age = current.Year - DateOfBirth.Year;
                if (current < DateOfBirth.AddYears(age))
                    age--;

                return age;
            }
        }

        public Customer():this(99999, "Uncle Sam", "Uncle.Sam@US.gov", new DateTime(1776, 7, 4), false)
        { }

        public Customer(int customerId, string name, string email, DateTime dateOfBirth, bool isAlumnum)
        {
            CustomerId = customerId;
            Name = name;
            Email = email;
            DateOfBirth = dateOfBirth;
            IsAlumnum = isAlumnum;
        }

    }
}
