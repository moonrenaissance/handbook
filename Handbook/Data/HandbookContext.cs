using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Handbook.Models;

namespace Handbook.Data
{
    public class HandbookContext : DbContext
    {
        public HandbookContext (DbContextOptions<HandbookContext> options)
            : base(options)
        {
        }

        public DbSet<Handbook.Models.Employees> Employees { get; set; } = default!;
    }
}
