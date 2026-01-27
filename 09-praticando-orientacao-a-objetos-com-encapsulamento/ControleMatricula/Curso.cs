class Curso
{
    public string Nome { get; set; }
    public int VagasTotais { get; set; }
    private List<Estudante> matriculas;
    public int VagasDisponiveis { get { return (VagasTotais - matriculas.Count); } }

    public Curso(string nome, int vagasTotais)
    {
        Nome = nome;
        VagasTotais = vagasTotais;
        matriculas = new List<Estudante>();
    }

    public bool Matricular(Estudante estudante)
    {
        if (matriculas.Count < VagasTotais)
        {
            matriculas.Add(estudante);
            Console.WriteLine("Estudante matriculado com sucesso.");
            return true;
        }
        else
        {
            Console.WriteLine("Erro: Não há vagas disponíveis para este curso.");
            return false;
        }
    }

    public void ListarMatriculados()
    {
        Console.WriteLine($"\nEstudantes matriculados em {Nome}:");
        foreach (var estudante in matriculas)
        {
            Console.WriteLine($"- {estudante.Nome}");
        }
        Console.WriteLine($"Vagas disponíveis: {VagasDisponiveis}");
    }
}
