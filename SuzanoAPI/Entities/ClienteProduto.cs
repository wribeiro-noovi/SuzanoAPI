namespace SuzanoAPI.Entities
{
    public class ClienteProduto
    {
        public int Cliente_Id { get; set; }
        public int Produto_Id { get; set; }

        public virtual Cliente? Cliente { get; set; }
        public virtual Produto? Produto { get; set; }
    }
}
