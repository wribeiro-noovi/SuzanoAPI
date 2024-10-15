using Microsoft.EntityFrameworkCore;
using SuzanoAPI.Contracts;
using SuzanoAPI.Entities;
using SuzanoAPI.Request.Cliente;

namespace SuzanoAPI.Repositories.DataAcess
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly SuzanoDbContext _context;
        private readonly ClienteRepository _cliente;
        public ProdutoRepository(SuzanoDbContext context, ClienteRepository cliente)
        {
            _context = context;
            _cliente = cliente;
        } 

        public Produto GetProduto(RequestBodyClienteJson doc)
        {
            var cliente = _cliente.GetCliente(doc); if (cliente is null) return null;
            var produto = _context.produto.Include(p => p.ClientesProdutos).ThenInclude(cp => cp.Cliente).Where(c => c.Id == cliente.Id).FirstOrDefault();
            return produto;
        }
    }
}
