class Musica
{
    public Musica(Banda artista, string nomeDaMusica)
    {
        Artista = artista;
        Nome = nomeDaMusica;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string InformacaoFormatada => $"A música {Nome} pertence à banda {Artista}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no seu plano!\n");
        }
        else
        {
            Console.WriteLine("Disponível apenas no plano ScreenSound Plus!\n");
        }
    }
}