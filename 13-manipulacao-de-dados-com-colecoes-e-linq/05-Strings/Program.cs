using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var stream = new StreamReader(arquivo);

var musicas = ObterMusicas(stream).Take(10);

foreach (var musica in musicas) Console.WriteLine(musica);

void StringInterning()
{
    var artista1 = "Coldplay";
    var artista2 = new String("Coldplay");
    var artista3 = "COLDPLAY"; // interning
    var artista4 = string.Intern(artista1.ToUpper());

    Console.WriteLine(artista3 == artista4); // True
    Console.WriteLine(artista1.Equals(artista2, StringComparison.OrdinalIgnoreCase)); // True
    Console.WriteLine(ReferenceEquals(artista1, artista2)); // True
    Console.WriteLine(ReferenceEquals(artista3, artista4)); // True?
}

void ComparacaoEntreStrings(StreamReader stream)
{
    var musicas = ObterMusicas(stream)
    .Where(musica => musica.Artista.Equals("COLDPLAY", StringComparison.OrdinalIgnoreCase))
    //.Where(musica => musica.Artista.ToUpper() == "COLDPLAY")
    .Take(50);

    ExibirMusicasEmTabela(musicas);

    // métodos que utilizam StringComparison
    "Coldplay".Equals("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".StartsWith("cold", StringComparison.OrdinalIgnoreCase);
    "Coldplay".EndsWith("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".IndexOf("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".Contains("OLD", StringComparison.OrdinalIgnoreCase);
    "Coldplay".Replace("cold", "warm", StringComparison.OrdinalIgnoreCase);
}

void AlterandoTituloEArtista(StreamReader stream)
{
    // alterar o nome de uma música
    var musicaMaisLonga = ObterMusicas(stream)
        .MaxBy(m => m.Duracao);

    if (musicaMaisLonga is not null)
    {
        Console.WriteLine($"Música mais longa é {musicaMaisLonga.Titulo} do {musicaMaisLonga.Artista} com {musicaMaisLonga.Duracao / 60} minutos.");

        // The Eletric Dream => Detalhes
        musicaMaisLonga.Titulo = musicaMaisLonga.Titulo.Replace("e", "3");
        musicaMaisLonga.Artista = musicaMaisLonga.Artista.ToUpper();

        Console.WriteLine($"Música mais longa é {musicaMaisLonga.Titulo} do {musicaMaisLonga.Artista} com {musicaMaisLonga.Duracao / 60} minutos.");
    }
    else Console.WriteLine("Não havia uma música nessa condição");
}


void StringComoArrayDeChar()
{
    char[] caracteres; // equivalente a uma string

    var musicasComT = ObterMusicas(stream)
        .Where(m => m.Titulo.StartsWith('T'))
        //.Where(m => m.Titulo[0] == 'T')
        .OrderBy(m => m.Lancamento)
        .Take(50);

    ExibirMusicasEmTabela(musicasComT);
}

void ValidandoSenhaForte()
{
    var senha = "Daniel@7";
    /* 
        Senha será forte se:
        0. possui pelo menos 8 caracteres
        1. possui alguma letra maiúscula
        2. possui alguma letra minúscula
        3. possui algum número
        4. possui algum símbolo
     */
    var totalCaracteres = senha.Count();
    var totalMaiusculas = senha.Count(c => char.IsLetter(c) && char.IsUpper(c));
    var totalMinusculas = senha.Count(c => char.IsLetter(c) && char.IsLower(c));
    var totalNumeros = senha.Count(c => char.IsDigit(c));
    var totalSimbolos = senha.Count(c => !char.IsLetterOrDigit(c));
    if (totalCaracteres < 8 || totalMaiusculas == 0 || totalMinusculas == 0 || totalNumeros == 0 || totalSimbolos == 0)
    {
        Console.WriteLine("Senha digitada é fraca!");
    }
    else
    {
        Console.WriteLine("Senha digitada é forte!");
    }

}

void ExibirMusicas(IEnumerable<Musica> musicas)
{
    var titulo = "\nMúsicas do arquivo:"; // string literal
    //var titulo = new string("Músicas do arquivo:"); // alocação tradicional
    Console.WriteLine(titulo);
    foreach (var musica in musicas)
    {
        var linha = $"\t- {musica.Titulo} ({musica.Artista}) - {musica.Duracao}s [{musica.Lancamento}]";
        //var linha2 = "\t- " + musica.Titulo + " (" + musica.Artista + ") " + musica.Duracao + "s [" + musica.Lancamento + "]";
        Console.WriteLine(linha);
    }
}

void ExibirMusicasEmTabela(IEnumerable<Musica> musicas)
{
    var titulo = "\nMúsicas do arquivo:"; // string literal
    //var titulo = new string("Músicas do arquivo:"); // alocação tradicional
    Console.WriteLine(titulo);

    var colunaTitulo = "TÍTULO".PadRight(40);  // 40
    var colunaArtista = "ARTISTA".PadRight(30); // 30
    var colunaDuracao = "DURAÇÃO".PadRight(10); // 10
    var colunaLancamento = "LANÇADA EM".PadRight(10); // 10
    var borda = "".PadRight(100, '=');

    Console.WriteLine($"\n{colunaTitulo}{colunaArtista}{colunaDuracao}{colunaLancamento}");
    Console.WriteLine(borda);
    foreach (var musica in musicas)
    {
        //var duracao = string.Format("{0,-10:F2}", musica.Duracao / 60.0);
        //var linha = $"{musica.Titulo,-40}{musica.Artista,-30}{duracao}{musica.Lancamento,-10}";
        var linha = $"{musica.Titulo,-40}{musica.Artista,-30}{(musica.Duracao / 60.0),-10:F2}{musica.Lancamento,-10:dd/MM/yyyy}";
        //var linha2 = "\t- " + musica.Titulo + " (" + musica.Artista + ") " + musica.Duracao + "s [" + musica.Lancamento + "]";
        Console.WriteLine(linha);
        //Console.WriteLine(musica);
    }
}

IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
    var linha = stream.ReadLine();
    while (linha is not null)
    {
        var partes = linha.Split(';');

        //int duracao = int.Parse(partes[2]);

        if (partes.Length == 5)
        {
            var musica = new Musica
            {
                Titulo = string.IsNullOrWhiteSpace(partes[0]) ? "Título Desconhecido" : partes[0],
                Artista = string.IsNullOrWhiteSpace(partes[1]) ? "Artista Desconhecido" : partes[1],
                Duracao = int.TryParse(partes[2], out int duracao) ? duracao : 350,
                Generos = partes[3].Split(',', StringSplitOptions.TrimEntries),
                Lancamento = DateTime.TryParse(partes[4], out var lcto) ? lcto : DateTime.Now
            };
            yield return musica;
        }

        linha = stream.ReadLine();
    }
}

class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public IEnumerable<string> Generos { get; set; }
    public DateTime Lancamento { get; set; }

    public override string ToString()
    {
        return $"{this.Titulo} de {this.Artista}, com {this.Duracao / 60.0:F2}min., lançada em {this.Lancamento:dd/MM/yyyy}";
    }
}