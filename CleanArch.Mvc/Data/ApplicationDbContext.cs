using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Mvc.Data
{
    public class UniversityIdentityDbContext : IdentityDbContext
    {
        public UniversityIdentityDbContext(DbContextOptions<UniversityIdentityDbContext> options)
            : base(options)
        {
        }
    }
}
