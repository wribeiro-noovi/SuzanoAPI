using SuzanoAPI.Entities;
using SuzanoAPI.Request.Cliente;

namespace SuzanoAPI.Contracts
{
    public interface IProdutoRepository
    {
        Produto GetProduto(RequestBodyClienteJson doc);
    }
}
