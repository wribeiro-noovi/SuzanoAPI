using Microsoft.EntityFrameworkCore;
using SuzanoAPI.Contracts;
using SuzanoAPI.Entities;
using SuzanoAPI.Request.Cliente;

namespace SuzanoAPI.Repositories.DataAcess
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SuzanoDbContext _context;
        public ClienteRepository(SuzanoDbContext context) => _context = context;

        public Cliente GetCliente(RequestBodyClienteJson doc)
        {
            var cliente = _context.cliente.FirstOrDefault(c => c.Documento.Equals(doc.Documento));

            if (cliente is null) return null;
            else return cliente;
        }
    }
}
