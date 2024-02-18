using AluguelDeCarrosAPI.Model;

namespace AluguelDeCarrosAPI.Interface.Service
{
    public interface IClienteService
    {
        Task<bool> CreateCliente(Cliente Cliente);
        Task<int> UpDateCliente(Cliente Cliente);
        Task<bool> DeletarCliente(int ClienteId);
        Task<List<Cliente>> ListarCliente();
    }
}
