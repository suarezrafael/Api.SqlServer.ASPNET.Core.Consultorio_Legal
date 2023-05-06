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

        // Insert
        public async Task<Cliente> InsertClienteAsync(Cliente cliente)
        {
            await clContext.Clientes.AddAsync(cliente);
            await clContext.SaveChangesAsync();
            return cliente;
        }

        // Update
        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {

            var clienteConsultado = await clContext.Clientes.FindAsync(cliente.Id);

            if(clienteConsultado == null) 
            {
                return null;
            }

            //clienteConsultado.Nome = cliente.Nome;
            //clienteConsultado.DataNascimento = cliente.DataNascimento;
            // vai verifcar match de campos e faz atribuições de valores se necessário
            clContext.Entry(clienteConsultado).CurrentValues.SetValues(cliente);

            // nesse caso nao precisa do update 
            //clContext.Clientes.Update(clienteConsultado);
            await clContext.SaveChangesAsync();
            return clienteConsultado;
        }

        // Delete
        public async Task DeleteClienteAsync(int id)
        {
            var clienteConsultado = await clContext.Clientes.FindAsync(id);

            if (clienteConsultado == null)
            {
                return;
            }
            clContext.Clientes.Remove(clienteConsultado);
            await clContext.SaveChangesAsync();
            
        }
    }
}
