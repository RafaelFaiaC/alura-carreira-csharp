class Funcionario
{
    public string Nome { get; set; }
    private decimal salario;
    public decimal Salario { get { return salario; } }

    public Funcionario(string nome, decimal salarioInicial)
    {
        Nome = nome;
        salario = salarioInicial;
    }

    public void ReajustarSalario(decimal novoSalario)
    {
        if (novoSalario > salario)
        {
            salario = novoSalario;
        }
        else
        {
            Console.WriteLine("Erro: O novo salário deve ser maior que o atual.");
        }
    }
}
