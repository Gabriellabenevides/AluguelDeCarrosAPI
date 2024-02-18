using AluguelDeCarrosAPI.Data;
using AluguelDeCarrosAPI.Interface.Repository;
using AluguelDeCarrosAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AluguelDeCarrosAPI.Repository
{
    public class CarroRepository : ICarrosRepository
    {
        private readonly SqlContext _context;

        public CarroRepository(SqlContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Carro> AlugarCarro(string nomeCarro)
        {
            Carro Carro = await _context.Carros.Where(x => x.Nome == nomeCarro).FirstOrDefaultAsync();
            return Carro;
        }

        public async Task<Carro> CreateCarro(Carro carro)
        {
            var ret = await _context.Carros.AddAsync(carro);
            await _context.SaveChangesAsync();
            ret.State = EntityState.Detached;
            return ret.Entity;
        }

        public async Task<bool> DeletarCarro(int carroId)
        {
            var removido = await _context.Carros.FindAsync(carroId);
            _context.Carros.Remove(removido);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Carro>> ListarCarro()
        {
            return await _context.Carros.OrderBy(p => p.Nome).ToListAsync();
        }

        public async Task<int> UpDateCarro(Carro carro)
        {
            _context.Entry(carro).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
    }
}
