using Microsoft.AspNetCore.Identity;

namespace CommunityFitChallenge.Web.Data
{
    public class CommunityFitUser : IdentityUser
    {
        public string FullName { get; set; }

        public decimal InitialWeightInKilos { get; set; }
    }
}