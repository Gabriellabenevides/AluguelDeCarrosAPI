using AluguelDeCarrosAPI.Data;
using AluguelDeCarrosAPI.Interface.Repository;
using AluguelDeCarrosAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarrosAPI.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SqlContext _context;

        public ClienteRepository(SqlContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Cliente> CreateCliente(Cliente Cliente)
        {
            var ret = await _context.Clientes.AddAsync(Cliente);
            await _context.SaveChangesAsync();
            ret.State = EntityState.Detached;
            return ret.Entity;
        }

        public async Task<bool> DeletarCliente(int ClienteId)
        {
            var removido = await _context.Clientes.FindAsync(ClienteId);
            _context.Clientes.Remove(removido);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Cliente>> ListarCliente()
        {
            return await _context.Clientes.OrderBy(p => p.Id).ToListAsync();
        }

        public async Task<int> UpDateCliente(Cliente Cliente)
        {
            _context.Entry(Cliente).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
    }
}
