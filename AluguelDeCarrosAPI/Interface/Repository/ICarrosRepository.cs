using AluguelDeCarrosAPI.Model;

namespace AluguelDeCarrosAPI.Interface.Repository
{
    public interface ICarrosRepository
    {
        Task<Carro> CreateCarro(Carro Carro);
        Task<int> UpDateCarro(Carro Carro);
        Task<bool> DeletarCarro(int CarroId);
        Task<List<Carro>> ListarCarro();
        Task<Carro> AlugarCarro(string nomeCarro);
    }
}
