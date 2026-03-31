//Você está desenvolvendo um sistema de formatação automática para posts em um fórum online. Os usuários frequentemente digitam textos com múltiplos espaços entre palavras ou até mesmo espaços desnecessários no início e no final. Seu programa precisa garantir que o texto seja exibido de forma limpa e padronizada excluindo os espaços extras antes de ser publicado.

//Crie um programa que:
//Receba uma string contendo um texto com espaços extras.
//Substitua todos os espaços consecutivos por um único espaço.
//Remova quaisquer espaços no início ou no final do texto.
//Exiba o texto formatado corretamente.

//Exemplo de entrada:
//Digite sua frase:
//    Olá, mundo!Como   vocês    estão?

//Saída esperada:
//Texto limpo: "Olá, mundo! Como vocês estão?"

using System.Text.RegularExpressions;

Regex regex = new Regex (@"\s+");

Console.WriteLine("Digite sua frase: ");
string frase = Console.ReadLine()!;

string textoLimpo = regex.Replace(frase, " ").Trim();

Console.WriteLine($"Texto limpo: {textoLimpo}");