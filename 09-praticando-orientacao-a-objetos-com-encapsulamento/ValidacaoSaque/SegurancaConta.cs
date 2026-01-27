internal class SegurancaConta
{
    internal static bool ValidarSaque(decimal valor)
    {
        return valor <= 1000;
    }
}
