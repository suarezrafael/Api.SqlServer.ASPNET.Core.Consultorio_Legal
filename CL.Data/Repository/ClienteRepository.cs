using CL.Core.Domain;
using CL.Data.Context;
using CL.Manager.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClContext clContext;

        public ClienteRepository(ClContext clContext)
        {
            this.clContext = clContext;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await clContext.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> GetClienteAsync(int id)
        {
            return await clContext.Clientes.FindAsync(id);
        }
    }
}
