/*
   Seja um aplicativo de gerenciamento de músicas onde os usuários podem organizar suas faixas favoritas em playlists personalizadas. Para cada playlist, é essencial que o usuário tenha controle total sobre a sequência de reprodução das músicas, permitindo reordená-las livremente a qualquer momento. Além disso, o aplicativo precisa oferecer a funcionalidade de reprodução aleatória para uma playlist específica, proporcionando uma experiência de audição dinâmica e variada, sem, contudo, alterar a ordem original que o usuário definiu. O desafio é criar uma estrutura robusta que suporte a adição e remoção eficiente de músicas, a reordenação flexível dentro das playlists e a seleção de faixas tanto em modo sequencial quanto aleatório.

   Funções que vamos implementar:
   //     [x] Criar as classes para musicas e playlist
   //     [x] Listar músicas da playlist
   //     [x] Adicionar música à playlist
   //     [x] Obter uma música específica da playlist
   //     [x] Remover música da playlist
   //     [x] Tocar uma música aleatória da playlist
   //     [x] Reordenar músicas segundo alguma lógica específica (ex. duração)
   //     [x] Uma playlist não pode ter músicas repetidas
   //     [x] Exibir as 10 músicas mais tocadas em todas as playlists (ranking)
   //     [x] Player de música com:
   //     [x] - Fila de reprodução (para músicas avulsas e/ou playlists)
   //     [x] - Histórico de reprodução

*/

using System.Collections;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

var musica1 = new Musica
{
    Titulo = "Que país é esse?",
    Artista = "Legião Urbana",
    Duracao = 280
};

var musica2 = new Musica { Titulo = "Tempo Perdido", Artista = "Legião Urbana", Duracao = 455 };
var musica3 = new Musica { Titulo = "Pro Dia Nascer Feliz", Artista = "Barão Vermelho", Duracao = 345 };
var musica4 = new Musica { Titulo = "Eduardo e Mônica", Artista = "Legião Urbana", Duracao = 800 };
var musica5 = new Musica { Titulo = "Geração Coca-Cola", Artista = "Legião Urbana", Duracao = 350 };

var rockNacional = new Playlist { Nome = "Rock Nacional" };
rockNacional.AdicionarMusica(musica1);
rockNacional.AdicionarMusica(musica2);
rockNacional.AdicionarMusica(musica3);
rockNacional.AdicionarMusica(musica4);
rockNacional.AdicionarMusica(musica5);
rockNacional.AdicionarMusica(musica5);

//ExibirPlaylist(rockNacional);

//Console.WriteLine("\nOrdenando playlist por duração:");
//rockNacional.OrdenarPorDuracao();
//ExibirPlaylist(rockNacional);

//Console.WriteLine("\nOrdenando playlist por título:");
//rockNacional.OrdenarPorTitulo();
//ExibirPlaylist(rockNacional);


//ObterMusicaPeloTitulo("Tempo Rei");
//for(var i = 1; i < 5; i++) ObterMusicaAleatoria();

var legiaoUrbana = new Playlist { Nome = "Top Legião Urbana" };
legiaoUrbana.AdicionarMusica(musica1);
legiaoUrbana.AdicionarMusica(musica2);
legiaoUrbana.AdicionarMusica(musica4);
legiaoUrbana.AdicionarMusica(musica5);
//ExibirPlaylist(legiaoUrbana);


//ExibirMaisTocadas(rockNacional, legiaoUrbana);

var player = new PlayerDeMusica();

player
    .AdicionarNaFila(new Musica { Titulo = "Bohemian Rapsody", Artista = "Queen", Duracao = 679 });

player.AdicionarNaFila(new Musica { Titulo = "Tempo Rei", Artista = "Gilberto Gil", Duracao = 356 });

player.AdicionarNaFila(new Musica { Titulo = "Dancing Queen", Artista = "Abba", Duracao = 409 });

ExibirFila();
ExibirHistorico();

TocarMusica(player.TocarProximaMusica());
ExibirFila();
ExibirHistorico();

TocarMusica(player.TocarProximaMusica());
ExibirFila();
ExibirHistorico();

TocarMusica(player.MusicaAnterior());


void ExibirFila()
{
    Console.WriteLine($"\nFila de Reprodução Atual:");
    foreach (var musica in player.Fila())
    {
        Console.WriteLine($"\t- {musica.Titulo}");
    }
}

void ExibirHistorico()
{
    Console.WriteLine($"\nHistórico de Execução Atual:");
    foreach (var musica in player.Historico())
    {
        Console.WriteLine($"\t- {musica.Titulo}");
    }
}

void TocarMusica(Musica? musica)
{
    if (musica is not null)
        Console.WriteLine($"\nVocê está ouvindo {musica.Titulo}...");
    else Console.WriteLine("\nNão há música a ser tocada!"); ;
}

void ExibirMaisTocadas(Playlist playlist1, Playlist playlist2)
{
    //Imprimir - Que País é esse; tocada X vezes

    //planilha com duas colunas: Música, Contagem
    var ranking = new Dictionary<Musica, int>();

    foreach (var musica in playlist1)
    {
        ranking.Add(musica, 1);
    }

    foreach (var musica in playlist2)
    {
        if (ranking.TryGetValue(musica, out int value))
        {
            ranking[musica] = ++value;
        }
        else
        {
            ranking[musica] = 1;
        }
    }

    // como pegar o Top 10? Ordenar por contagem
    Console.WriteLine("\nRanking das 10 mais tocadas");
    var rankingOrdenado = new List<KeyValuePair<Musica, int>>(ranking);
    rankingOrdenado.Sort(new MusicaPorContagemDescrescente());
    int contador = 1;
    foreach (var par in rankingOrdenado)
    {
        Console.WriteLine($"\t{par.Key.Titulo} foi tocada {par.Value} vezes.");
        contador++;
        if (contador > Math.Min(rankingOrdenado.Count, 10)) break;
    }
}

void ObterMusicaAleatoria()
{
    var musica = rockNacional.ObterMusicaAleatoria();
    Console.WriteLine($"A música aleatória é {musica.Titulo}");
}


void ObterMusicaPeloTitulo(string titulo)
{
    var musicaEncontrada = rockNacional.ObterMusicaPeloTitulo(titulo);
    if (musicaEncontrada is not null) Console.WriteLine($"Música {titulo} encontrada!");
    else Console.WriteLine("Música não existe na playlist");
}

void ExibirPlaylist(Playlist playlist)
{
    Console.WriteLine($"Você está ouvindo {playlist.Nome}");
    foreach (var musica in playlist)
    {
        Console.WriteLine($"\t-{musica.Titulo}");
    }
}

class MusicaPorContagemDescrescente : IComparer<KeyValuePair<Musica, int>>
{
    public int Compare(KeyValuePair<Musica, int> x, KeyValuePair<Musica, int> y)
    {
        return y.Value.CompareTo(x.Value);
    }
}

class MusicaPorTitulo : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null && y is null) return 0;
        if (x is null) return -1;
        if (y is null) return 1;
        return x.Titulo.CompareTo(y.Titulo);
    }
}


class Musica : IComparable<Musica>
{
    public required string Titulo { get; set; }
    public required string Artista { get; set; }
    public required int Duracao { get; set; }

    public int CompareTo(Musica? other) // -1 (menor), 0 (igual), 1 (maior)
    {
        if (other is null) return -1;
        return this.Duracao.CompareTo(other.Duracao);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is Musica musica)
            return this.Titulo.Equals(musica.Titulo) &&
                this.Artista.Equals(musica.Artista);
        return false;
    }

    public override int GetHashCode()
    {
        return this.Titulo.GetHashCode() ^ this.Artista.GetHashCode();
    }
}

class Playlist : IEnumerable<Musica>
{
    private List<string> titulos = [];
    private List<Musica> musicas = [];
    private HashSet<Musica> musicasSet = [];

    public required string Nome { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        //var encontrou = false;
        //foreach(var m in musicas)
        //{
        //    if (m.Equals(musica))
        //    {
        //        encontrou = true;
        //        break;
        //    }
        //}

        if (musicasSet.Add(musica))
        {
            musicas.Add(musica);
            titulos.Add(musica.Titulo);
        }
    }

    public void RemoverMusica(string titulo)
    {
        var musica = ObterMusicaPeloTitulo(titulo);
        if (musica is not null) musicas.Remove(musica);
    }

    public Musica? ObterMusicaPeloTitulo(string titulo)
    {
        var indice = titulos.IndexOf(titulo);
        if (indice >= 0) return musicas[indice];
        return null;

        //foreach(var musica in musicas)
        //{
        //    if (musica.Titulo == titulo) return musica;
        //}
        //return null;
    }

    public Musica ObterMusicaAleatoria()
    {
        var random = new Random();
        var indice = random.Next(0, musicas.Count - 1);
        return musicas[indice];
    }

    public void OrdenarPorDuracao()
    {
        musicas.Sort();
    }

    public void OrdenarPorTitulo()
    {
        musicas.Sort(new MusicaPorTitulo());
    }

    public IEnumerator<Musica> GetEnumerator()
    {
        return musicas.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


class PlayerDeMusica
{
    private Queue<Musica> _fila = []; //primeiro a sair é o primeiro a entrar (FIFO)
    // histórico: o primeiro a sair é o último a entrar (LIFO)
    private Stack<Musica> _historico = [];

    public void AdicionarNaFila(Musica musica)
    {
        _fila.Enqueue(musica);
    }

    public void AdicionarNaFila(Playlist playlist)
    {
        foreach (var musica in playlist) _fila.Enqueue(musica);
        //_fila.AddRange(playlist);
    }

    public Musica? TocarProximaMusica()
    {
        if (_fila.Count == 0) return null;
        // primeira a ser adicionada é a próxima
        var proxima = _fila.Dequeue(); // IndexOutOfRangeException
        //_fila.RemoveAt(0);
        //_fila.Remove(proxima);
        _historico.Push(proxima);
        return proxima;
    }

    public Musica? MusicaAnterior()
    {
        if (_historico.Count == 0) return null;
        return _historico.Pop();
    }

    public IEnumerable<Musica> Fila()
    {
        foreach (var musica in _fila)
            yield return musica;
    }

    public IEnumerable<Musica> Historico()
    {
        foreach (var musica in _historico)
            yield return musica;
    }
}