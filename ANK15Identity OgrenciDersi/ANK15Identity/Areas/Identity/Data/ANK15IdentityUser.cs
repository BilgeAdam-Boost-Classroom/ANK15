using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ANK15Identity.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ANK15IdentityUser class
public class ANK15IdentityUser : IdentityUser
{
    //Ekstra özellikleri buraya yazacağız...
    public string Name { get; set; }

    public string SurName { get; set; }

    public List<Lesson> Lessons { get; set; }


}

