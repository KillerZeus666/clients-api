using Microsoft.AspNetCore.Mvc;
using ClientesApi.Models;
using ClientesApi.Services;

namespace ClientesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly ClienteService _servicio;

    public ClientesController(ClienteService servicio)
    {
        _servicio = servicio;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cliente>>> Get() =>
        Ok(await _servicio.ObtenerTodos());

    [HttpGet("{id}")]
    public async Task<ActionResult<Cliente>> Get(int id)
    {
        var cliente = await _servicio.ObtenerPorId(id);
        return cliente is null ? NotFound() : Ok(cliente);
    }

    [HttpPost]
    public async Task<ActionResult<Cliente>> Post(Cliente cliente)
    {
        var nuevo = await _servicio.Agregar(cliente);
        return CreatedAtAction(nameof(Get), new { id = nuevo.Id }, nuevo);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var eliminado = await _servicio.Eliminar(id);
        return eliminado ? NoContent() : NotFound();
    }
}