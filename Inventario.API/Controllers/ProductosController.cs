using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inventario.API.Data;
using Inventario.API.Models;


[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase
{

    private readonly AppDbContext _context;

    public ProductosController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _context.Productos.ToListAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Post(Producto producto)
    {
        _context.Productos.Add(producto);
        await _context.SaveChangesAsync();
        return Ok(producto);
    }
}