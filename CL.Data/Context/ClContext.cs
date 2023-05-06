using CL.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CL.Data.Context
{
    public class ClContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public ClContext(DbContextOptions dbContextOptions ) : base(dbContextOptions)
        {
        }
    }
}
