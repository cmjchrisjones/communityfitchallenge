using Microsoft.AspNetCore.Identity;
using System;

namespace CommunityFitChallenge.Web.Data
{
    public class CommunityFitUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string EmailAddress { get; set; }

        public string Nickname { get; set; }

        public decimal InitialWeightInKilos { get; set; }

        public bool UserProfileIsCompleted { get; set; }
    }
}