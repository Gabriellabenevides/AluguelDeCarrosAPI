using AluguelDeCarrosAPI.Model;

namespace AluguelDeCarrosAPI.Interface.Repository
{
    public interface IClienteRepository
    {
        Task<Cliente> CreateCliente(Cliente Cliente);
        Task<int> UpDateCliente(Cliente Cliente);
        Task<bool> DeletarCliente(int ClienteId);
        Task<List<Cliente>> ListarCliente();
    }
}
