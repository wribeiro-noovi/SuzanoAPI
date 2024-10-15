using Microsoft.AspNetCore.Mvc;
using SuzanoAPI.Request.Cliente;
using SuzanoAPI.UseCase.Produtos.GetProduto;

namespace SuzanoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : SuzanoBaseController
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpPost("GetProduto")]
        public IActionResult GetProduto([FromBody] RequestBodyClienteJson json,
                                        [FromServices] GetProdutoUseCase useCase)
        {
            var produto = useCase.Execute(json);
            if (produto is null) return NoContent();

            return Ok(produto.Nome);
        }
    }
}
