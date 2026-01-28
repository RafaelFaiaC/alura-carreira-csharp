class Bicicleta : Transporte
{
    public override int CalcularTempo(int km)
    {
        return km * 4;
    }
}