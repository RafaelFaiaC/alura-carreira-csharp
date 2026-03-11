using System.Collections;
using System.Collections.Generic;

var diasDaSemana = new string[] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

var carrinho = new List<Produto>()
{
    new Produto { Id = 1, Nome = "Leite", Preco = 6.89 }
};

carrinho.Add(new Produto { Id = 2, Nome = "Biscoito", Preco = 3.99 });

var dias = new DiasDaSemana();

//PercorrendoColecaoComFor();
//PercorrendoColecaoComWhile();
//PercorrendoColecaoComForEach();
//PercorrendoColecaoComEnumerator();
//PercorrendoDiasComEnumerator();
//PercorrendoOsTresPrimeirosDias();
//ImprimeNumerosPares(50);

var pares = NumerosPares(30);
ImprimeNumerosParesSemLimitacao();

void ImprimeNumerosParesSemLimitacao()
{
    foreach (var numero in pares) Console.WriteLine(numero);
}

void ImprimeNumerosPares(int limite)
{
    int contador = 1;
    foreach (var numero in pares)
    {
        Console.WriteLine(numero);
        contador++;
        if (contador > limite) break;
    }
}

IEnumerable<int> NumerosPares(int limite)
{
    int contador = 1;
    int numeroAtual = 0;
    while (true)
    {
        //Console.WriteLine("Gerando o próximo número par...");
        yield return numeroAtual += 2;
        contador++;
        if (contador > limite) yield break;
    }
}

void PercorrendoOsTresPrimeirosDias()
{
    int contador = 1;
    foreach (var dia in dias)
    {
        Console.WriteLine(dia);
        contador++;
        if (contador > 3) break;
    }
}

void PercorrendoDiasComEnumerator()
{
    var enumerator = dias.GetEnumerator();
    while (enumerator.MoveNext())
    {
        var dia = enumerator.Current;
        Console.WriteLine(dia);
    }
}

void PercorrendoColecaoComEnumerator()
{
    var enumerator = carrinho.GetEnumerator(); //IEnumerable + IEnumerator
    while (enumerator.MoveNext())
    {
        var produto = enumerator.Current;
        Console.WriteLine($"Produto {produto.Nome} - {produto.Preco:F2}");
    }
}

void PercorrendoColecaoComForEach()
{
    foreach (var produto in carrinho) //IEnumerable + IEnumerator
    {
        Console.WriteLine($"Produto {produto.Nome} - {produto.Preco:F2}");
    }
    foreach (var dia in diasDaSemana)
    {
        Console.WriteLine(dia);
    }
}

void PercorrendoColecaoComWhile()
{
    int i = 0;
    while (i < diasDaSemana.Length)
    {
        var dia = diasDaSemana[i];
        Console.WriteLine($"Dia {dia}");
        i++;
    }

}

void PercorrendoColecaoComFor()
{
    for (int i = 0; i < carrinho.Count; i++)
    {
        var produto = carrinho[i];
        Console.WriteLine($"Produto {produto.Nome} - {produto.Preco:F2}");
    }
}

class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class DiasDaSemanaEnumerator : IEnumerator<string>
{
    private int posicao = -1;
    private string[] diasDaSemana = new string[] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

    public string Current => diasDaSemana[posicao];

    object IEnumerator.Current => Current;

    public void Dispose() { }

    public bool MoveNext()
    {
        posicao++;
        return posicao < diasDaSemana.Length;
    }

    public void Reset()
    {
        posicao = -1;
    }
}

class DiasDaSemana : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        yield return "Domingo";
        yield return "Segunda";
        yield return "Terça";
        Console.WriteLine("Vai chegar aqui?");
        yield return "Quarta";
        yield return "Quinta";
        yield return "Sexta";
        yield return "Sábado";
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}