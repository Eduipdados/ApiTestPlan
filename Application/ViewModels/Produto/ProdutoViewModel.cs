namespace Api.Application.ViewModels.Produto
{
    public class ProdutoViewModel
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string GupoQuimico { get; set; }
        public string PrincipioAtivo { get; set; }
        public string Concentracao { get; set; }
        public string RegistroSaude { get; set; }
    }
}