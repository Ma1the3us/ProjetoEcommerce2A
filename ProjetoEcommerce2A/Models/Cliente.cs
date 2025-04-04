namespace ProjetoEcommerce2A.Models
{
    public class Cliente
    {
        public int CodCli {get; set; }
        public string? NomeCli { get; set; }
        public string? TelCli { get; set; }
        public string? EmailCli { get; set; }
        public List<Cliente>? ListarCliente { get; set; }
    }
}
