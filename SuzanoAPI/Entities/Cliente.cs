namespace SuzanoAPI.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime CadastradoEm { get; set; }
        public string Documento { get; set; } = string.Empty;

        
        public virtual ICollection<Ani>? Ani { get; set; }
        public virtual ICollection<ClienteProduto>? ClientesProdutos { get; set; }
    }
}
