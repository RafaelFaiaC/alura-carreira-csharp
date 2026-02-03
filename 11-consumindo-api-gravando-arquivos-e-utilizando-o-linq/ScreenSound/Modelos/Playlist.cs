using System.Text.Json;

namespace ScreenSound.Modelos;

internal class Playlist
{
    public string Nome { get; set; }
    public List<Musica> MusicasDaPlaylist { get; }

    public Playlist(string nome)
    {
        Nome = nome;
        MusicasDaPlaylist = new List<Musica>();
    }

    public void AdicionarMusica(Musica musica)
    {
        MusicasDaPlaylist.Add(musica);
    }

    public void ExibirMusicasDaPlaylist()
    {
        Console.WriteLine($"Playlist: {Nome}");
        foreach (var musica in MusicasDaPlaylist)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = MusicasDaPlaylist
        });
        string nomeDoArquivo = $"D:/Repositórios/alura-carreira-csharp/11-consumindo-api-gravando-arquivos-e-utilizando-o-linq/ScreenSound/{Nome}-Playlist.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine("Arquivo gerado com sucesso!");
    }
}
