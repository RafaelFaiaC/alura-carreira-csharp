//Você está desenvolvendo um sistema de validação de respostas para um quiz online. O sistema recebe uma lista de pontuações de participantes (de 0 a 10) e precisa classificá-los como "Reprovado" (se a pontuação for menor que 6) ou "Aprovado" (se a pontuação for maior ou igual que 6).

//Para isso, você precisará de um programa que:
//Armazene as notas dos participantes em uma lista.
//Percorra cada nota usando um laço.
//Utilize uma estrutura condicional para classificar e exibir a situação de cada participante.

//Exemplo de entrada:
//List<int> notas = new List<int> { 4, 7, 5, 9, 6 };

//Saída esperada:
//Nota 4 - Reprovado
//Nota 7 - Aprovado
//Nota 5 - Reprovado
//Nota 9 - Aprovado
//Nota 6 - Aprovado

List<int> notas = new List<int> { 4, 7, 5, 9, 6 };

foreach (int nota in notas)
{
    if (nota < 6)
    {
        Console.WriteLine($"Nota {nota} - Reprovado");
    }
    else
    {
        Console.WriteLine($"Nota {nota} - Aprovado");
    }
}