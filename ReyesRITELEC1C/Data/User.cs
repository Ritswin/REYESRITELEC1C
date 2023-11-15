using System;
using Microsoft.AspNetCore.Identity;


namespace ReyesRITELEC1C.Data

{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
