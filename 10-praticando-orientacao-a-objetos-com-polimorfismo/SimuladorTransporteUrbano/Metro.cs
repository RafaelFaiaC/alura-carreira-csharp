class Metro : Transporte
{
    public override int CalcularTempo(int km)
    {
        return km + 5;
    }
}