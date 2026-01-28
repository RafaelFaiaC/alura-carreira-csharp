class Midia
{
    public string Nome { get; set; }

    public Midia(string nome)
    {
        Nome = nome;
    }

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Mídia: {Nome}");
    }
}
