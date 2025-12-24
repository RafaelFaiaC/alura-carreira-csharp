class Pedido
{
    public Pedido(string numeroPedido, string nomeCliente, string status)
    {
        NumeroPedido = numeroPedido;
        NomeCliente = nomeCliente;
        Status = status;
    }

    public string NumeroPedido { get; set; }
    public string NomeCliente { get; set; }
    public string Status { get; set; }

    public void AtualizarStatus(string novoStatus)
    {
        Status = novoStatus;
    }

    public void ExibirPedido()
    {
        Console.WriteLine($"Pedido nº {NumeroPedido}");
        Console.WriteLine($"Cliente: {NomeCliente}");
        Console.WriteLine($"Status: {Status}\n");
    }
}