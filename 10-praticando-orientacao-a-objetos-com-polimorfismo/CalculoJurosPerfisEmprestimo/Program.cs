//Você está desenvolvendo um simulador de empréstimos para uma fintech. O sistema precisa calcular o valor final de um empréstimo baseado em perfis diferentes de clientes, cada um com uma taxa de juros mensal distinta.

//O cálculo deve seguir a fórmula de juros simples:
//ValorFinal = ValorEmprestado + (ValorEmprestado × Taxa × Meses)

//As taxas são:
//Estudante: 1 % ao mês
//Empresário: 2.5 % ao mês
//Aposentado: 1.5 % ao mês

//Sua missão é:
//Criar uma interface IEmprestimo com o método CalcularValorFinal(decimal valor, int meses).
//Criar as classes EmprestimoEstudante, EmprestimoEmpresario e EmprestimoAposentado, que implementam essa interface.
//Simular o valor final de um empréstimo de R$1000 por 12 meses para cada perfil.

//Exemplo de entrada:
//List<IEmprestimo> perfis = new List<IEmprestimo>
//{
//    new EmprestimoEstudante(),
//    new EmprestimoEmpresario(),
//    new EmprestimoAposentado()
//};

//foreach (var perfil in perfis)
//{
//    decimal total = perfil.CalcularValorFinal(1000m, 12);
//    Console.WriteLine($"{perfil.GetType().Name}: R${total:0.00}");
//}

//Exemplo de saída:
//EmprestimoEstudante: R$1120.00
//EmprestimoEmpresario: R$1300.00
//EmprestimoAposentado: R$1180.00

List<IEmprestimo> perfis = new List<IEmprestimo>
{
    new EmprestimoEstudante(),
    new EmprestimoEmpresario(),
    new EmprestimoAposentado()
};

foreach (var perfil in perfis)
{
    decimal total = perfil.CalcularValorFinal(1000m, 12);
    Console.WriteLine($"{perfil.GetType().Name}: R${total:0.00}");
}