using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OCOS_System.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NameOfBusiness { get; set; }

        public string Password { get; set; }

        public string StoreNumber { get; set; }

        public bool isAdmin { get; set; }

        public string Position { get; set; }

        public int ContactId { get; set; }

        public string EmployeeId { get; set; }

        // public int[] WorkHours { get; set; }

        public string Roles { get; set; }

        public List<ApplicationUser> Employees { get; set; }

        public EmployeeStatus Status { get; set; }
    }
    public enum EmployeeStatus
    {
        Active,
        Inactive
    }
}

