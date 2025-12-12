//Você precisa construir uma minicalculadora que realiza uma operação matemática com dois números. O usuário deve digitar o primeiro número, o segundo número e qual operação deseja fazer: soma(+), subtração(-), multiplicação(*) ou divisão(/). Com base na operação digitada, o programa deve calcular e exibir o resultado.

//Crie um programa que:

//Receba dois números digitados pelo usuário.
//Pergunte qual a operação matemática deseja realizar (+, -, *, /).
//Exiba “Operação inválida” caso a entrada seja diferente das operações acima.
//Exiba o resultado de acordo com a operação escolhida.

//Exemplo de entrada:
//Digite o primeiro número: 5
//Digite o segundo número: 5
//Digite a operação (+, -, *, /): *

//Saída esperada:
//Resultado: 25

Console.Write("Digite o primeiro número: ");
float primeiroNumero = float.Parse(Console.ReadLine()!);
Console.Write("Digite o segundo número: ");
float segundoNumero = float.Parse(Console.ReadLine()!);
Console.Write("Digite a operação: ");
string operacao = Console.ReadLine()!;

switch (operacao)
{
    case "+":
        Console.WriteLine("Resultado: " + (primeiroNumero + segundoNumero));
        break;
    case "-":
        Console.WriteLine("Resultado: " + (primeiroNumero - segundoNumero));
        break;
    case "*":
        Console.WriteLine("Resultado: " + (primeiroNumero * segundoNumero));
        break;
    case "/":
        Console.WriteLine("Resultado: " + (primeiroNumero / segundoNumero));
        break;
    default:
        Console.WriteLine("Operação inválida.");
        break;
}