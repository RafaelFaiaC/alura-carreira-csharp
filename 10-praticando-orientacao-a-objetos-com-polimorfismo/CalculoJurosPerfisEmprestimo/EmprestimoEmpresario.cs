class EmprestimoEmpresario : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        decimal taxa = 0.025m;
        return valor + (valor * taxa * meses);
    }
}