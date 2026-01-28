class AulaGravada : Conteudo
{
    public int Duracao { get; set; }

    public AulaGravada(string titulo, int duracao) : base(titulo)
    {
        Duracao = duracao;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Duração: {Duracao} min\n");
    }
}
