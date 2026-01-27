class Quarto
{
    public int Numero { get; set; }

    private double valorDiaria;
    public double ValorDiaria
    {
        get { return valorDiaria; }
        set
        {
            if (value > 0)
                valorDiaria = value;
            else
                Console.WriteLine("Erro: O valor da diária deve ser maior que zero.");
        }
    }

    public Quarto(int numero)
    {
        Numero = numero;
    }
}