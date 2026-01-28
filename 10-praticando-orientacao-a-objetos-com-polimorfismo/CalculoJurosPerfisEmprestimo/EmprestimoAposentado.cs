class EmprestimoAposentado : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        decimal taxa = 0.015m;
        return valor + (valor * taxa * meses);
    }
}