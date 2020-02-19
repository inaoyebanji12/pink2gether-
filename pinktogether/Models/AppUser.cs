﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace pinktogether.Models
{
    public class AppUser : IdentityUser<int>
    {
        [PersonalData, Required, StringLength(20)]
        public string FirstName { get; set; }

        [PersonalData, Required, StringLength(20)]
        public string LastName { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}