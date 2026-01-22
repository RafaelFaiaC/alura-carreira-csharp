class Passageiro : Pessoa
{
    public int QuantidadeBilhetes { get; }

    public Passageiro (string nome, int idade, int quantidadeBilhetes) : base (nome, idade)
    {
        QuantidadeBilhetes = quantidadeBilhetes;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Passageiro: {Nome} - Idade: {Idade} - Bilhetes: {QuantidadeBilhetes}");
    }
}
