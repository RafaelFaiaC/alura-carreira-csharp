//Você está desenvolvendo um sistema de análise de textos para uma plataforma de escrita criativa. Os autores precisam saber o tamanho exato de seus textos para atender aos requisitos de publicação. Seu objetivo é criar uma ferramenta que conte os caracteres de qualquer texto inserido.

//Para isso, você precisa de um programa que:

//Solicite ao usuário que digite uma frase.
//Calcule o número total de caracteres (incluindo espaços).
//Exiba o resultado no console.

//Exemplo de entrada:
//Digite uma frase: Aprendendo a programar

//Saída esperada:
//A frase contém 22 caracteres.

Console.Write("Digite uma frase: ");
string frase = Console.ReadLine()!;

Console.WriteLine($"A frase contém {frase.Length} caracteres.");