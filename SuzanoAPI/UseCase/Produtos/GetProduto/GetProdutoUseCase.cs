using SuzanoAPI.Contracts;
using SuzanoAPI.Entities;
using SuzanoAPI.Request.Cliente;

namespace SuzanoAPI.UseCase.Produtos.GetProduto
{
    public class GetProdutoUseCase
    {
        private readonly IProdutoRepository _repository;
        public GetProdutoUseCase(IProdutoRepository repository) => _repository = repository;

        public Produto Execute(RequestBodyClienteJson doc) => _repository.GetProduto(doc);
    }
}
