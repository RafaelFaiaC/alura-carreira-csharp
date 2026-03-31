//Imagine que você está desenvolvendo um sistema de validação para cupons de desconto em um e-commerce. Cada cupom deve conter apenas números para ser considerado válido. Seu programa precisa identificar quais códigos estão no formato correto antes de serem cadastrados no sistema.

//Crie um programa que:
//Receba uma string representando um código.
//Verifique se contém apenas dígitos numéricos (0-9) usando expressões regulares.
//Retorne um booleano e o exiba na tela se o código é ou não válido.

//Exemplo de entrada:
//Digite o código do cupom:
//123456

//Saída esperada:
//Se o código for válido:
//O código é válido

//Caso não seja:
//O código não é válido.

using System.Text.RegularExpressions;

Console.Write("Digite o código do cupom: ");
string codigoCupom = Console.ReadLine()!;

Regex regexCupom = new Regex(@"^\d+$");
if (regexCupom.IsMatch(codigoCupom))
{
    Console.WriteLine("O código é válido.");
}
else
{
    Console.WriteLine("O código não é válido.");
}