class ContaBancaria
{
    public string Titular { get; set; }
    private decimal saldo;
    public decimal Saldo { get { return saldo; } }

    public ContaBancaria(string titular, decimal saldoInicial)
    {
        Titular = titular;
        saldo = saldoInicial;
    }

    public void Sacar(decimal valor)
    {
        if (SegurancaConta.ValidarSaque(valor))
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso.");
            Console.WriteLine($"Saldo atual: R${saldo}");   
        }
        else
        {
            Console.WriteLine("Saque negado pela política de segurança.");
        }
    }
}
