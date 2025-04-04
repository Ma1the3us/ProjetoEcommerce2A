namespace ProjetoEcommerce2A.Models
{
    public class ClienteClass
    {
        public int CodCli {get; set; }
        public string? NomeCli { get; set; }
        public string? TelCli { get; set; }
        public string? EmailCli { get; set; }
        public List<Cliente>? ListarCliente { get; set; }
    }
}
