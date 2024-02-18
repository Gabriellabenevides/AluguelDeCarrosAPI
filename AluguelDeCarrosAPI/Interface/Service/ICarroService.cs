using AluguelDeCarrosAPI.Model;
using System.Collections.Generic;

namespace AluguelDeCarrosAPI.Interface.Service
{
    public interface ICarroService
    {
        Task<bool> CreateCarro(Carro Carro);
        Task<int> UpDateCarro(Carro Carro);
        Task<bool>DeletarCarro(int carroId);
        Task<List<Carro>> ListarCarro();
        Task<Carro> AlugarCarro(string nomeCarro);

    }
}
