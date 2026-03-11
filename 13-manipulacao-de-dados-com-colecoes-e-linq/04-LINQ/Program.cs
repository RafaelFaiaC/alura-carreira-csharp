/*
    Seja um arquivo com músicas em formato CSV (Comma Separated Values). 

    Implemente as funções abaixo:
    //     [x] Leia-o como uma coleção de músicas
    //     [x] Filtre a coleção por artista (por ex. Coldplay, Metallica, AC/DC)
    //     [x] Filtre a coleção por duração (por ex. maiores que 5 minutos)
    //     [x] Ordene a coleção por artista
    //     [x] Ordene a coleção por artista e em seguida por músicas com duração crescente
    //     [x] Recupere as 10 músicas mais longas
    //     [x] Crie uma coleção de artistas
    //     [x] Crie uma coleção de gêneros
    //     [x] Informe a duração média das músicas da coleção
    //     [x] Informe a duração total das músicas da coleção
    //     [x] Crie uma coleção de artistas e suas músicas
    //     [x] Informe qual artista tem mais músicas na coleção
    //     [x] Filtre a coleção por gênero (por ex. rock)
 
*/

using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var stream = new StreamReader(arquivo);

/*
 
  Fluxo Padrão: Estágio 1 (Origem Dados) > Estágio 2 > ... > Estágio N

  LINQ - Categorias de operações para manipulação de coleções 
  ========================================================================================
  | Filtro (+)      | coleção c/ tam menor/igual atendendo condição | Where, Distinct    |
  | Projeção (+)    | coleção transformada, do mesmo tipo ou não    | Select, SelectMany |
  | Ordenação (*)   | coleção ordenada pela expressão lambda        | OrderBy, ThenBy    |
  | Agregação (*)   | valor único a partir de operação de acúmulo   | Sum, Min, Max      |
  | Agrupamento (+) | coleção de grupos onde a chave é o argumento  | GroupBy            |
  | Elementos (*)   | elemento único T a partir do argumento        | First, Last, MinBy |
  | Existência (*)  | booleano a partir da operação e argumento     | All, Any, Contains |
  | Conversão (*)   | coleção em outra estrutura                    | ToList, ToArray    |
  ========================================================================================

    + operações avaliadas sob demanda (yield)
    * operações avaliadas imediatamente
*/


void OperacoesDeVerificacaoDeExistencia(StreamReader stream)
{
    // retornam booleano a partir de uma condição
    var musicas = ObterMusicas(stream).ToList();

    Console.WriteLine($"\nArtistas que possuam todas músicas abaixo de 400 segundos:");
    var artistas = musicas
        .GroupBy(m => m.Artista)
        .Where(a => a.All(m => m.Duracao <= 400));
    foreach (var artista in artistas)
    {
        Console.WriteLine($"\n\t{artista.Key} ({artista.Count()})");
        foreach (var musica in artista)
        {
            Console.WriteLine($"\t- {musica.Titulo} ({musica.Duracao} segs.)");
        }
    }

    Console.WriteLine($"\nArtistas com pelo menos uma música de reggae");
    var artistasRock = musicas
        .GroupBy(m => m.Artista)
        .Where(a => a.Any(m => m.Generos.Contains("Reggae")));
    foreach (var artista in artistasRock)
    {
        Console.WriteLine($"\n\t{artista.Key} ({artista.Count()})");
        foreach (var musica in artista)
        {
            Console.WriteLine($"\t- {musica.Titulo} ({string.Join(',', musica.Generos)})");
        }
    }

    Console.Write($"\nLista possui músicas de Jazz? ");
    var contemJazz = musicas.Exists(m => m.Generos.Contains("Jazz"));
    if (contemJazz)
    {
        Console.WriteLine("Sim!");
    }
    else
    {
        Console.WriteLine("Não...");
    }
}

void OperacoesDeObtencaoDeElementos(StreamReader stream)
{
    var musicas = ObterMusicas(stream).ToList();

    var primeira = musicas.FirstOrDefault();
    if (primeira is not null)
        Console.WriteLine($"A primeira música é {primeira.Titulo}");

    var ultima = musicas.LastOrDefault();
    if (ultima is not null)
        Console.WriteLine($"A última música é {ultima.Titulo}");

    var primeiraCaetano = musicas.FirstOrDefault(m => m.Artista == "Caetano Veloso");
    if (primeiraCaetano is not null)
        Console.WriteLine($"A primeira do Caetano é {primeiraCaetano.Titulo}");
}

void ArtistaComMaisMusicas(StreamReader stream)
{
    var artistaComMaiorQtde = ObterMusicas(stream)
        .GroupBy(m => m.Artista)
        .Select(g => new { Artista = g.Key, Musicas = g, Total = g.Count() })
        .MaxBy(g => g.Total); // obtenção de elemento

    if (artistaComMaiorQtde is not null)
        Console.WriteLine($"O artista com maior quantidade de músicas é {artistaComMaiorQtde.Artista} com um total de {artistaComMaiorQtde.Total}");
}

void ArtistasESuasMusicas(StreamReader stream)
{
    var artistas = ObterMusicas(stream)
        .GroupBy(m => m.Artista)
        .OrderBy(g => g.Key)
        .Take(5)
        .ToList(); // materializando

    Console.WriteLine($"\nLista dos 5 primeiros artistas e suas músicas");
    foreach (IGrouping<string, Musica> artista in artistas)
    {
        Console.WriteLine($"\n\t{artista.Key} ({artista.Count()})");
        foreach (var musica in artista.OrderBy(m => m.Titulo).Take(5))
        {
            Console.WriteLine($"\t - {musica.Titulo}");
        }
    }
}

void EstatisticasDasMusicas(StreamReader stream)
{
    var musicas = ObterMusicas(stream).ToList(); //materializar a coleção

    Console.WriteLine($"\nExistem {musicas.Count()} músicas na coleção.");
    Console.WriteLine($"\nExistem {musicas.Count(m => m.Duracao > 600)} músicas com mais do que 10 minutos na coleção.");
    Console.WriteLine($"\nA música com menor duração da coleção leva {musicas.Min(m => m.Duracao)} segundos.");
    Console.WriteLine($"\nA música com maior duração da coleção leva {musicas.Max(m => m.Duracao)} segundos.");
    Console.WriteLine($"\nA duração média das músicas da coleção é {musicas.Average(m => m.Duracao):F2} segundos.");
    Console.WriteLine($"\nVocê vai levar {musicas.Sum(m => m.Duracao) / (24 * 360):F2} dias para ouvir toda a coleção!");
}

void ProjetandoGeneros(StreamReader stream)
{
    var generos = ObterMusicas(stream)
        //.Select(m => m.Generos); // IEnumerable<Musica> -> IEnumerable<string[]> !
        .SelectMany(m => m.Generos) // IEnumerable<Musica> -> IEnumerable<string> (achata)
        .Distinct()
        .OrderBy(g => g);

    Console.WriteLine($"\nListando Gêneros:");
    foreach (var genero in generos)
    {
        Console.WriteLine($"\t - {genero}");
    }
}

void ProjetandoArtistas(StreamReader stream)
{
    //var artistas = ObterMusicas(stream)
    //    .DistinctBy(m => m.Artista) // filtro baseado na igualdade do argumento do método
    //    .Select(m => m.Artista)
    //    .OrderBy(a => a);

    var artistas = ObterMusicas(stream)
        .Select(m => m.Artista) // transformação/projeção/mapeamento entre tipos (T -> Z)
        .Distinct() // filtro baseado na igualdade dos elementos de entrada
        .OrderBy(a => a);

    Console.WriteLine($"\nArtistas no arquivo:");
    foreach (var artista in artistas)
    {
        Console.WriteLine($"\t - {artista}");
    }
}

void OperacoesDeFiltroEOrdenacao(StreamReader stream)
{
    var musicasDoMetallica = ObterMusicas(stream) //obtenção dos dados: arquivos
        .Where(m => m.Artista.StartsWith("M"))
        .Skip(5)
        .Take(10)
        .OrderBy(m => m.Artista)
        //.OrderByDescending(m => m.Artista) // modo decrescente
        //.ThenBy(m => m.Titulo)
        .ThenByDescending(m => m.Duracao); // Em seguida ordene por...

    ExibirMusicas(musicasDoMetallica);
}

void ExibirMusicas(IEnumerable<Musica> musicas)
{
    Console.WriteLine("\n10 Primeiras músicas do arquivo:");
    foreach (var musica in musicas)
    {
        Console.WriteLine($"\t- {musica.Titulo} ({musica.Artista}) - {musica.Duracao} segundos");
    }
}

IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
    var linha = stream.ReadLine();
    while (linha is not null)
    {
        //Console.WriteLine("Processando linha...");
        var partes = linha.Split(';');
        var musica = new Musica
        {
            Titulo = partes[0],
            Artista = partes[1],
            Duracao = Convert.ToInt32(partes[2]),
            Generos = partes[3].Split(',').Select(g => g.Trim())
        };
        yield return musica;
        linha = stream.ReadLine();
    }
}

class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public IEnumerable<string> Generos { get; set; }
}