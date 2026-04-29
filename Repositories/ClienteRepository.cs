using ClientesApi.Data;
using ClientesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientesApi.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly ClientesContext _context;

    public ClienteRepository(ClientesContext context)
    {
        _context = context;
    }

    public async Task<List<Cliente>> GetAllAsync() =>
        await _context.Clientes.ToListAsync();

    public async Task<Cliente?> GetByIdAsync(int id) =>
        await _context.Clientes.FindAsync(id);

    public async Task<Cliente> AddAsync(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();
        return cliente;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        if (cliente == null) return false;

        _context.Clientes.Remove(cliente);
        await _context.SaveChangesAsync();
        return true;
    }
}