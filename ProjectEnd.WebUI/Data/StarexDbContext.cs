using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ProjectEnd.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEnd.WebUI.Data
{
    public class StarexDbContext : IdentityDbContext<AppUsers>
    {
    }
}
