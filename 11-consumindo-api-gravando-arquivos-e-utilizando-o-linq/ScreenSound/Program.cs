using ScreenSound.Modelos;
using System.Text.Json;
using ScreenSound.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqFilter.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "Rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        LinqFilter.FiltrarMusicasPorDoSustenido(musicas);

        //var playlist1 = new Playlist("Primeira Playslist");
        //playlist1.AdicionarMusica(musicas[1]);
        //playlist1.AdicionarMusica(musicas[377]);
        //playlist1.AdicionarMusica(musicas[4]);
        //playlist1.AdicionarMusica(musicas[6]);
        //playlist1.AdicionarMusica(musicas[1467]);
        //playlist1.ExibirMusicasDaPlaylist();

        //playlist1.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema : {ex.Message}");
    }
}