namespace SuzanoAPI.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public virtual ICollection<ClienteProduto>? ClientesProdutos { get; set; }
    }
}
