class ProdutoDigital
{
    public ProdutoDigital(string nome, decimal preco, InformacaoTecnica infoTecnica)
    {
        Nome = nome;
        Preco = preco;
        InfoTecnica = infoTecnica;
    }

    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public InformacaoTecnica InfoTecnica { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine("Produto: " + Nome);
        Console.WriteLine("Preço: R$ " + Preco.ToString("F2"));
        Console.WriteLine("Tamanho: " + InfoTecnica.TamanhoMB + "MB");
        Console.WriteLine("Compatível com: " + InfoTecnica.SistemaOperacional);
    }
}