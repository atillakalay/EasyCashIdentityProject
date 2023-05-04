﻿using Microsoft.AspNetCore.Identity;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
    }
}
