/*
    Seja um arquivo com músicas em formato CSV (Comma Separated Values). 

    Implemente as funções abaixo:
    //     [x] Leia-o como uma coleção de músicas
    //     [x] Filtre a coleção por artista (por ex. Coldplay, Metallica, AC/DC)
    //     [ ] Filtre a coleção por duração (por ex. maiores que X segundos)
    //     [ ] Ordene a coleção por artista
    //     [ ] Ordene a coleção por artista e em seguida por músicas com duração crescente
    //     [ ] Crie uma coleção de artistas e suas músicas
    //     [ ] Informe a duração média das músicas da coleção
    //     [ ] Informe a duração total das músicas da coleção
    //     [ ] Informe qual artista tem mais músicas na coleção
 
*/

using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var stream = new StreamReader(arquivo);

var musicasDoMetallica = ObterMusicas(stream) //obtenção dos dados: arquivos

    .Where(m => m.Artista.StartsWith("C"))
    .Where(musica => musica.Duracao <= 350);

ExibirMusicas(musicasDoMetallica);

void ExibirMusicas(IEnumerable<Musica> musicas)
{
    var contador = 1;
    Console.WriteLine("\n10 Primeiras músicas do arquivo:");
    foreach (var musica in musicas)
    {
        Console.WriteLine($"\t- {musica.Nome} ({musica.Artista}) - {musica.Duracao} segundos");
        contador++;
        if (contador > 10) break;
    }
}

IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
    var linha = stream.ReadLine();
    while (linha is not null)
    {
        Console.WriteLine("Processando linha...");
        var partes = linha.Split(';');
        var musica = new Musica
        {
            Nome = partes[0],
            Artista = partes[1],
            Duracao = Convert.ToInt32(partes[2]),
            Generos = []
        };
        yield return musica;
        linha = stream.ReadLine();
    }
}

// delegates
//bool MusicaEhDoColdplay(Musica m) => m.Artista == "Coldplay";
//bool MusicaEhDoRollingStones(Musica musica) => musica.Artista == "Rolling Stones";
//bool MusicaEhDoMetallica(Musica musica) => musica.Artista == "Metallica";
//bool MusicaEhMaiorQue400(Musica musica) => musica.Duracao >= 400;

//Func<Musica,bool> condicao = MusicaEhMaiorQue400;

static class MusicasExtensions
{
    public static IEnumerable<T> FiltraPor<T>(this IEnumerable<T> colecao, Func<T, bool> condicao)
    {
        foreach (var elemento in colecao)
        {
            if (condicao(elemento)) yield return elemento;
        }
    }
}

class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public string[] Generos { get; set; }
}