using SuzanoAPI.Entities;
using SuzanoAPI.Request.Cliente;

namespace SuzanoAPI.Contracts
{
    public interface IClienteRepository
    {
        Cliente GetCliente(RequestBodyClienteJson doc);
    }
}
