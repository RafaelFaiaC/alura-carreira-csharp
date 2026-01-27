public class Agenda
{
    public string Proprietario { get; set; }
    private readonly List<Contato> contatos;
    public int QuantidadeContatos { get { return contatos.Count; } }

    public Agenda(string proprietario)
    {
        Proprietario = proprietario;
        contatos = new List<Contato>();
    }

    public bool AdicionarContato(Contato contato)
    {
        if (contatos.Any(c => c.Nome == contato.Nome))
        {
            Console.WriteLine("Contato com esse nome já está na agenda.");
            return false;
        }

        contatos.Add(contato);
        return true;
    }

    public void ListarContatos()
    {
        Console.WriteLine("Agenda de: " + Proprietario);
        Console.WriteLine("Contatos:");
        foreach (var c in contatos)
        {
            Console.WriteLine("- " + c.Nome + " | " + c.Telefone);
        }
        Console.WriteLine("Total de contatos: " + QuantidadeContatos);
    }
}
    