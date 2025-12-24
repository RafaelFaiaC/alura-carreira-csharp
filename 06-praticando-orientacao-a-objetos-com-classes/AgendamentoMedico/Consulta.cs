class Consulta
{
    public Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
    {
        NomePaciente = nomePaciente;
        NomeMedico = nomeMedico;
        DataConsulta = dataConsulta;
        foiReagendada = false;
    }

    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }

    private bool foiReagendada;

    public void Reagendar(DateTime novaData)
    {
        DataConsulta = novaData;
        foiReagendada = true;
    }

    public void ExibirResumo()
    {
        Console.WriteLine("Consulta marcada com " + NomeMedico + " para o paciente " + NomePaciente + ".");
        if (foiReagendada)
        {
            Console.WriteLine("Nova data: " + DataConsulta.ToString("dd/MM/yyyy\n"));
        }
        else
        {
            Console.WriteLine("Data: " + DataConsulta.ToString("dd/MM/yyyy\n"));
        }
    }
}