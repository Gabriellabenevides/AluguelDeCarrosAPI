using AluguelDeCarrosAPI.Interface.Repository;
using AluguelDeCarrosAPI.Interface.Service;
using AluguelDeCarrosAPI.Model;
using AluguelDeCarrosAPI.Repository;

namespace AluguelDeCarrosAPI.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
        }
            
        public async Task<bool> CreateCliente(Cliente Cliente)
        {
            var result = await _clienteRepository.CreateCliente(Cliente);
            return result != null;
        }

        public async Task<bool> DeletarCliente(int ClienteId)
        {
            await _clienteRepository.DeletarCliente(ClienteId);
            return true;
        }

        public async Task<List<Cliente>> ListarCliente()
        {
            var cliente = await _clienteRepository.ListarCliente();
            return cliente;
        }

        public async Task<int> UpDateCliente(Cliente Cliente)
        {
            return await _clienteRepository.UpDateCliente(Cliente);
        }
    }
}
