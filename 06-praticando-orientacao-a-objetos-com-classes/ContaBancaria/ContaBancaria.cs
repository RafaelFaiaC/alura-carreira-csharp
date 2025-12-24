class ContaBancaria
{
    public ContaBancaria(string numeroConta, double saldo)
    {
        NumeroConta = numeroConta;
        Saldo = saldo;
    }

    public string NumeroConta { get; set;}
    public double Saldo { get; set; }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }
}