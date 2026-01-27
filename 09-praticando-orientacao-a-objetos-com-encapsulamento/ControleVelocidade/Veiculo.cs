class Veiculo
{
    public string Placa { get; set; }
    public double VelocidadeAtual { get { return velocidadeAtual; } }
    private double velocidadeAtual;

    public Veiculo(string placa)
    {
        Placa = placa;
    }

    public void AtualizarVelocidade(double novaVelocidade)
    {
        velocidadeAtual = novaVelocidade;
    }
}
