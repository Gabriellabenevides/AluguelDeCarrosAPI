using AluguelDeCarrosAPI.Interface.Repository;
using AluguelDeCarrosAPI.Interface.Service;
using AluguelDeCarrosAPI.Model;
using AluguelDeCarrosAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AluguelDeCarrosAPI.Service
{
    public class CarroService : ICarroService
    {
        private readonly ICarrosRepository _carroRepository;

        public CarroService(ICarrosRepository carroRepository)
        {
            _carroRepository = carroRepository ?? throw new ArgumentNullException(nameof(carroRepository));
        }

        public async Task<Carro> AlugarCarro(string nomeCarro)
        {
            var carro = await _carroRepository.AlugarCarro(nomeCarro);
           //carroDispinivel.Disponivel = "Nao";

           return carro;
        }
        

        public async Task<bool> CreateCarro(Carro carro)
        {
            var result = await _carroRepository.CreateCarro(carro);
            return result != null;
        }

        public async Task<bool> DeletarCarro(int carroId)
        {
            await _carroRepository.DeletarCarro(carroId);
            return true;
        }

        public async Task<List<Carro>> ListarCarro()
        {
            var carros = await _carroRepository.ListarCarro();
            return carros;
        }

        public async Task<int> UpDateCarro(Carro carro)
        {
            return await _carroRepository.UpDateCarro(carro);
        }
    }
}
