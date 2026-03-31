//Imagine que você está desenvolvendo um sistema para edição de textos e precisa permitir ao usuário substituir uma palavra por outra. O sistema deve ser *capaz de substituir todas as ocorrências de uma palavra dentro de uma frase.

//Para isso, você precisa criar um programa que:
//Receba uma frase digitada pelo usuário.
//Receba a palavra específica a ser substituída.
//Receba uma palavra nova para substituir a antiga.
//Realize a troca por uma nova palavra em todas as ocorrências.
//Exiba a frase modificada.

//Exemplo de entrada:
//Digite uma frase:
//Eu gosto de programar em Java

//Qual palavra você quer substituir?
//Java

//Por qual palavra?
//C#

//Saída esperada:
//Eu gosto de programar em C#

Console.Write("Digite uma frase: ");
string frase = Console.ReadLine()!;

Console.Write("Qual palavra você quer substituir? ");
string palavraAntiga = Console.ReadLine()!;

Console.Write("Por qual palavra? ");
string palavraNova = Console.ReadLine()!;

Console.WriteLine(frase.Replace(palavraAntiga, palavraNova));