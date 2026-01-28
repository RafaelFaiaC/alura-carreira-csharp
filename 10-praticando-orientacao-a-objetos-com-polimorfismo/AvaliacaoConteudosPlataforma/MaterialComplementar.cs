class MaterialComplementar : Conteudo
{
    public int Paginas { get; set; }

    public MaterialComplementar(string titulo, int paginas) : base(titulo)
    {
        Paginas = paginas;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Páginas: {Paginas}\n");
    }
}
