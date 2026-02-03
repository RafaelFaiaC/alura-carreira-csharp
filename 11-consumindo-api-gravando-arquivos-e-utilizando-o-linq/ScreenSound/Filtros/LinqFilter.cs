using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas
            .Select(m => m.Genero)
            .Distinct()
            .ToList();
        Console.WriteLine($"Gêneros:");
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas
            .Select(m => m.Artista)
            .Distinct()
            .OrderBy(a => a)
            .ToList();
        Console.WriteLine($"Artistas ordenados:");
        foreach (var artista in artistasOrdenados)
        {  
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string generoMusical)
    {
        var artistasPorGenero = musicas
            .Where(m => m.Genero!.Contains(generoMusical, StringComparison.OrdinalIgnoreCase))
            .Select(m => m.Artista)
            .Distinct()
            .OrderBy(a => a)
            .ToList();
        Console.WriteLine($"Artistas do gênero {generoMusical}:");
        foreach (var artista in artistasPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas
            .Where(m => m.Artista!.Equals(nomeDoArtista, StringComparison.OrdinalIgnoreCase))
            .Select(m => m.Nome)
            .Distinct()
            .OrderBy(m => m)
            .ToList();
        Console.WriteLine($"Músicas do artista {nomeDoArtista}:");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicasPorDoSustenido(List<Musica> musicas)
    {
        var musicasComDoSustenido = musicas
            .Where(m => m.Key.Equals(1))
            .Select(m => m.Nome)
            .ToList();

        Console.WriteLine($"Músicas em tonalidades com dó sustenido:");
        foreach (var musica in musicasComDoSustenido)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
