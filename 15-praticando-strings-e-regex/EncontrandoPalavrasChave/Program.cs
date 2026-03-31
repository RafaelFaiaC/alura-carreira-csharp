//Imagine que você está desenvolvendo um sistema de pesquisa em que o usuário digita uma consulta e o sistema precisa verificar se uma palavra-chave está presente na consulta. O sistema deverá exibir uma mensagem indicando se a palavra-chave foi encontrada ou não. Para isso, você precisa de um programa que:
//Declare uma variável para servir como palavra-chave.
//Receba um texto do usuário.
//Verifique se a palavra-chave está presente no texto.
//Exiba uma mensagem informando se a palavra foi encontrada ou não.

//Exemplo de entrada:
//Digite um texto:
//Aprendendo C# com exemplos práticos

//Saída esperada: Considerando C# como palavra-chave
//A palavra-chave foi encontrada na pesquisa.

string palavraChave = "C#";

Console.Write("Digite um texto: ");
string texto = Console.ReadLine()!;

if (texto.Contains(palavraChave))
{
    Console.WriteLine("A palavra-chave foi encontrada na pesquisa.");
}
else
{
    Console.WriteLine("A palavra-chave não foi encontrada na pesquisa.");
}