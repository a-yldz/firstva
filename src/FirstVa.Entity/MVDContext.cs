using System;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstVa.Entity
{
    public class MVDContext : IdentityDbContext<MVDUser>
    {
        public MVDContext(DbContextOptions options) : base(options)
        {
        }
    }
}
