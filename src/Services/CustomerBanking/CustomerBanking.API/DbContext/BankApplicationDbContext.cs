using CustomerBanking.API.IdentityAuth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerBanking.API.DbContext
{
    public class BankApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public BankApplicationDbContext(DbContextOptions<BankApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
