//Você está desenvolvendo um sistema de cadastro de eventos onde os usuários precisam inserir datas no formato exato "dd/mm/aaaa". Seu programa deve verificar se a data digitada está no padrão correto antes de permitir o cadastro.

//Crie um programa que:
//Receba uma string representando uma data.
//Verifique se ela está no formato "dd/mm/aaaa", onde:
//"dd" são dois dígitos para o dia
//"mm" são dois dígitos para o mês
//"aaaa" são quatro dígitos para o ano
//Retorne um booleano indicando se a data é válida e exiba o resultado na tela.

//Exemplo de entrada:
//Digite a data(dd / mm / aaaa):
//09 / 07 / 1992

//Saída esperada:
//A data está no formato correto.

//Ou então:
//Formato inválido!Use dd/mm/aaaa.

using System.Text.RegularExpressions;

Regex regex = new Regex(@"^\d{2}/\d{2}/\d{4}$");

Console.WriteLine("Digite a data (dd/mm/aaaa):");
string data = Console.ReadLine()!;

if (regex.IsMatch(data))
{
    Console.WriteLine("A data está no formato correto.");
}
else
{
    Console.WriteLine("Formato inválido! Use dd/mm/aaaa.");
}