class Funcionario
{
    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public string Nome { get; set; }
    public string Cargo { get; set; }

    public void Promover(string novoCargo)
    {
        if (Cargo != novoCargo)
        {
            Cargo = novoCargo;
            Console.WriteLine("\nPromoção realizada com sucesso!\n");
        }
        else
        {
            Console.WriteLine("\nErro: O novo cargo deve ser diferente do cargo atual.\n");
        }
        
    }
}