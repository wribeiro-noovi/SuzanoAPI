using Microsoft.AspNetCore.Mvc;
using SuzanoAPI.Repositories;

namespace SuzanoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly SuzanoDbContext _context;

        public TesteController(SuzanoDbContext context)
        {
            _context = context;
        }

        [HttpGet("test-connection")]
        public async Task<IActionResult> TestConnection()
        {
            try
            {
                // Tenta acessar o banco de dados
                await _context.Database.CanConnectAsync();
                return Ok("Conexão bem-sucedida!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao conectar: {ex.Message}");
            }
        }
    }
}
