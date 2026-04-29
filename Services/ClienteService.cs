using ClientesApi.Models;
using ClientesApi.Repositories;

namespace ClientesApi.Services;

public class ClienteService
{
    private readonly IClienteRepository _repo;

    public ClienteService(IClienteRepository repo)
    {
        _repo = repo;
    }

    public Task<List<Cliente>> ObtenerTodos() => _repo.GetAllAsync();
    public Task<Cliente?> ObtenerPorId(int id) => _repo.GetByIdAsync(id);
    public Task<Cliente> Agregar(Cliente cliente) => _repo.AddAsync(cliente);
    public Task<bool> Eliminar(int id) => _repo.DeleteAsync(id);
}