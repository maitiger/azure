using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UpAzure.Models
{
    public class UpAzureContext : DbContext
    {
        public UpAzureContext (DbContextOptions<UpAzureContext> options)
            : base(options)
        {
        }

        public DbSet<UpAzure.Models.Account> Account { get; set; }
    }
}
