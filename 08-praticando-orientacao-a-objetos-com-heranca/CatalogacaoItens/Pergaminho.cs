class Pergaminho : ItemDigital
{
    public string Descricao { get; }

    public Pergaminho (string titulo, string descricao) : base(titulo)
    {
        Descricao = descricao;
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine("Detalhes do Pergaminho:");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Descrição: {Descricao}");
    }
}
