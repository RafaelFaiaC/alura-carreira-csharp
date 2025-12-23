class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string host, string nome)
    {
        this.Nome = nome;
        this.Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios  => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
        foreach (Episodio episodio in episodios.OrderBy(x => x.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\nEste podcast possuí {TotalEpisodios} episódios");
    }
}